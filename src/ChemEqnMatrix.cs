using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    /// <summary>
    /// A class providing some methods for manipulating matrices.
    /// Constructing an object and providing a double[,] as the 
    /// argument allows use of the function SolveMatrix() which
    /// returns a double[,] in a modified reduced row echelon form.
    /// The leading coefficient is not necessarily one; however, 
    /// it and the adjunct vector could be divided by the leading
    /// coefficient and then it would be in rref.
    /// Constructing this object with a string that consists of a 
    /// valid chemical equation of the form CO2 + H2O = C6H12O6 + O2
    /// allows use of the function Balance() which returns a
    /// string with the equation properly balanced in lowest terms.
    /// </summary>
    public class ChemEqnMatrix
    {
        private double[,] matrix;
        String[] left;
        String[] right;
        int numElems;

        /// <summary>
        /// Constructing an object and providing a double[,] as the 
        /// argument allows use of the function SolveMatrix() which
        /// returns a double[,] in a modified reduced row echelon form.
        /// The leading coefficient is not necessarily one; however, 
        /// it and the adjunct vector could be divided by the leading
        /// coefficient and then it would be in rref. 
        /// </summary>
        /// <param name="matrix">A 2-D array that you want in rref.</param>
        public ChemEqnMatrix(double[,] matrix)
        {
            this.matrix = matrix;
        }

        /// <summary>
        /// Constructing this object with a string that consists of a 
        /// valid chemical equation of the form CO2 + H2O = C6H12O6 + O2
        /// allows use of the function Balance() which returns a
        /// string with the equation properly balanced in lowest terms. 
        /// </summary>
        /// <param name="s">A chemical equation that you want balanced.</param>
        public ChemEqnMatrix(String s)
        {
            Equation eqn = new Equation(s);
            //numElems = eqn.elements.Count();
            left = eqn.GetLeft();
            right = eqn.GetRight();

            List<String[,]> results = new List<String[,]>();

            for (int k = 0; k < left.Length; k++)
            {
                results.Add(eqn.Parse(left[k]));
            }

            for (int k = 0; k < right.Length; k++)
            {
                results.Add(eqn.Parse(right[k]));
            }

            PopulateMatrix(results, left.Length, right.Length, eqn);
            numElems = eqn.elements.Count();
        }

        /// <summary>
        /// Finds the index of the occurence of string of interest in a string array.
        /// </summary>
        /// <param name="s1">The string array that may contain s2.</param>
        /// <param name="s2">The string whose index you wish to find.</param>
        /// <returns>Returns the index of the occurence of string of interest in a 
        /// string array and -1 if not found.</returns>
        public int indexOf(string[] s1, string s2)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1[i].Equals(s2))
                {
                    return i;
                }
            }

            return -1;
        }//array

        /// <summary>
        /// Finds the index of the occurence of string of interest in a 2-D string array.
        /// </summary>
        /// <param name="s1">The 2-D string array that may contain s2.</param>
        /// <param name="s2">The string whose index you wish to find.</param>
        /// <returns>Returns the index of the occurence of string of interest in a 2-D 
        /// string array. Returns -1 if not found.</returns>
        public int indexOf(string[,] s1, string s2)
        {
            for (int i = 0; i < s1.Length / 2; i++)
            {
                if (s1[0, i].Equals(s2))
                {
                    return i;
                }
            }
            return -1;
        }//matrix

        /// <summary>
        /// Fills a matrix with the values gleaned from parsing the chemical
        /// equation.
        /// </summary>
        /// <param name="results">A matrix containing the elements used in a 
        /// a term in the top row and the number of times each element is used
        /// in the bottom row.</param>
        /// <param name="lSize">The number of terms in the left side of the
        /// chemical equation.</param>
        /// <param name="rSize">The number of terms in the right side of the
        /// chemical equation.</param>
        /// <param name="eqn">The equation to be balanced.</param>
        private void PopulateMatrix(List<String[,]> results, int lSize, int rSize, Equation eqn)
        {
            matrix = new double[eqn.elements.Count + 1, lSize + rSize + 1];

            matrix[eqn.elements.Count, 0] = 1;
            matrix[eqn.elements.Count, lSize + rSize] = 1;
            for (int i = 0; i < eqn.elements.Count; i++)
            {
                int j = 0;
                for (; j < lSize; j++)
                {
                    if (indexOf(results[j], eqn.elements[i]) > -1)
                    {
                        matrix[i, j] = double.Parse(results[j][1, indexOf(results[j], eqn.elements[i])]);
                    }
                }
                for (; j < lSize + rSize; j++)
                {
                    if (indexOf(results[j], eqn.elements[i]) > -1)
                    {
                        matrix[i, j] = -int.Parse(results[j][1, indexOf(results[j], eqn.elements[i])]);
                    }
                }
            }
            //Console.WriteLine("//////////////////////");
            //DisplayMatrix();
            //Console.WriteLine("//////////////////////");
        }

        /// <summary>
        /// Gets the values in the far right side of the 2-D array.
        /// These are then used to compute the solution of the matrix
        /// -- the coefficients of the terms in the equation
        /// </summary>
        /// <returns>Returns an array of the values in the far right 
        /// column of a matrix.</returns>
        public double[] GetAdjunctCol()
        {
            //double[] adjCol = new double[matrix.GetLength(0)];
            double[] adjCol = new double[left.Length + right.Length];
            for (int i = 0; i < adjCol.Length; i++)
            {
                adjCol[i] = matrix[i, matrix.GetLength(1) - 1];
            }
            return adjCol;
        }

        /// <summary>
        /// Gets the values in the main of the 2-D array.
        /// These are then used to compute the solution of the matrix
        /// -- the coefficients of the terms in the equation
        /// </summary>
        /// <returns>Returns an array of the values in the main 
        /// diagonal of a matrix.</returns>
        public double[] GetDiagonal()
        {
            //double[] diagonal = new double[matrix.GetLength(0)];
            double[] diagonal = new double[left.Length + right.Length];
            for (int i = 0; i < diagonal.Length; i++)
            {
                diagonal[i] = matrix[i, i];
            }
            return diagonal;
        }

        /// <summary>
        /// Determines the least common multiple of the values
        /// in the main diagonal of a matrix
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public double GetLCMDiagonal()
        {
            double lcm = matrix[0, 0];
            //DisplayMatrix(matrix);
            double temp;
            //for (int i = 0; i < matrix.GetLength(0); i++)
            for (int i = 0; i < left.Length + right.Length; i++)
            {
                temp = matrix[i, i];
                lcm = LCM(lcm, temp);
            }
            return lcm;
        }

        /// <summary>
        /// Finds the coefficients to the terms from the chemical equation.
        /// </summary>
        /// <returns>Returns an array containg the values of the coefficients of 
        /// the terms in the chemical equation.</returns>
        public int[] DetermineCoefficients()
        {
            double[] solution = GetAdjunctCol();
            double[] diagonal = GetDiagonal();
            double lcm = GetLCMDiagonal();

            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = lcm * solution[i];
            }

            for (int i = 0; i < solution.Length; i++)
            {
                solution[i] = solution[i] / diagonal[i];
            }

            int[] solutionI = new int[solution.Length];

            for (int i = 0; i < solution.Length; i++)
            {
                //Console.WriteLine(solution[i]);
                solutionI[i] = (int)(solution[i]);
            }
            return solutionI;
        }

        /// <summary>
        /// Determines the least common multiple of a pair of input numbers.
        /// </summary>
        /// <param name="a">One of a pair of values whose least common multiple is sought.</param>
        /// <param name="b">One of a pair of values whose least common multiple is sought.</param>
        /// <returns>Returns the value, as a double, of the least common multiple of the input numbers.</returns>
        public static double LCM(double a, double b)
        {
            double lcm = 0;
            lcm = a * b;
            double gcd = GCD(a, b);
            return lcm / gcd;
        }

        /// <summary>
        /// Inserts the coefficients into the chemical equation and thereby balancing it.
        /// </summary>
        /// <param name="answer">An array containing the coefficients of the terms.</param>
        /// <param name="left">The left side of the chemical equation.</param>
        /// <param name="right">The right side of the chemical equation.</param>
        /// <returns>Returns the balanced chemical equation as a string.</returns>
        string InsertCoeff(int[] answer, String[] left, String[] right)
        {
            StringBuilder final = new StringBuilder();
            int i = 0;
            for (int k = 0; k < answer.Length; k++)
            {
                if (Math.Abs(answer[k]) < 0.001)
                {
                    return "No solution";
                }
            }
            for (; i < left.Length; i++)
            {
                if (answer[i] > 1)
                {
                    left[i] = answer[i].ToString() + left[i];
                }
            }
            for (int j = 0; j < right.Length; j++)
            {
                if (answer[i] > 1)
                {
                    right[j] = answer[i].ToString() + right[j];
                }
                i++;
            }

            for (i = 0; i < left.Length; i++)
            {
                if (i > 0)
                {
                    final.Append(" + ");
                }
                final.Append(left[i]);
            }
            final.Append(" = ");

            for (i = 0; i < right.Length; i++)
            {
                if (i > 0)
                {
                    final.Append(" + ");
                }
                final.Append(right[i]);
            }
            return final.ToString();
        }

        /// <summary>
        /// Balances the chemical equation.
        /// </summary>
        /// <returns>Returns the balanced chemical equation as a string.</returns>
        public string Balance()
        {
            //Console.WriteLine("???????????????????????");
            //DisplayMatrix();
            //Console.WriteLine("???????????????????????");
            SolveMatrix();
            return InsertCoeff(DetermineCoefficients(), left, right);
        }

        /// <summary>
        /// Swaps two rows in the matrix based on the input values.
        /// </summary>
        /// <param name="r1">The index of the first row to be swapped.</param>
        /// <param name="r2">The index of the second row to be swapped.</param>
        public void SwapRows(int r1, int r2)
        {
            double temp;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                temp = matrix[r1, i];
                matrix[r1, i] = matrix[r2, i];
                matrix[r2, i] = temp;
            }
        }

        /// <summary>
        /// Organizes the matrix by determining if the current row is out of place, 
        /// and if so, swapping it with the appropriate row.
        /// </summary>
        /// <param name="currentRow">The index of the row that may be swapped.</param>
        public void FindAndSwap(int currentRow)
        {
            double smallest = double.MaxValue;
            int currentRowLeadingCoeffPos = -1;
            int first = matrix.GetLength(1) - 1;
            int rowToSwitch = currentRow;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (Math.Abs(matrix[currentRow, i]) > 0.001)
                {
                    currentRowLeadingCoeffPos = i;
                    first = currentRowLeadingCoeffPos;
                    break;
                }
            }
            if (currentRowLeadingCoeffPos > currentRow)
            {
                for (int i = currentRow; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        if (matrix[i, j] != 0)
                        {
                            currentRowLeadingCoeffPos = j;
                            break;
                        }
                    }
                    if (currentRowLeadingCoeffPos < first)
                    {
                        first = currentRowLeadingCoeffPos;
                        rowToSwitch = i;
                    }
                }
            }
            for (int i = first; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, first] < smallest && Math.Abs(matrix[i, first]) > 0.1)
                {

                    smallest = matrix[i, first];
                    //Console.WriteLine("SMALLEST " + smallest + " i " + i);
                    rowToSwitch = i;
                }
            }
            //if (currentRow != rowToSwitch)
            if (currentRow < rowToSwitch)
            {
                SwapRows(currentRow, rowToSwitch);
                return;
            }
        }

        /// <summary>
        /// Finds the appropriate scalars from the two input rows for 
        /// proper row reduction.
        /// </summary>
        /// <param name="row1">The index of the first row whose scalar is sought.</param>
        /// <param name="row2">The index of the second row whose scalar is sought.</param>
        /// <returns>Returns an array containing the scalars of the two input rows.</returns>
        public double[] FindScalars(int row1, int row2)
        {
            double[] lcm = new double[2];
            int posLCR1 = 0;

            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (Math.Abs(matrix[row1, i]) > 0.001)
                {
                    posLCR1 = i;
                    lcm[0] = matrix[row1, i];
                    break;
                }
            }

            lcm[1] = matrix[row2, posLCR1];
            if (Math.Abs(matrix[row2, posLCR1]) < 0.001)
            {
                lcm[0] = 0;
                return lcm;
            }

            return lcm;
        }

        /// <summary>
        /// Determines the greatest common denominator of a pair of input values.
        /// </summary>
        /// <param name="x">The first of a pair of values whose gcd is sought.</param>
        /// <param name="y">The second of a pair of values whose gcd is sought.</param>
        /// <returns>Returns the greatest common denominator of a pair of input values.</returns>
        public static double GCD(double x, double y)
        {
            double a = Math.Abs(x);
            double b = Math.Abs(y);
            double c;
            while (b > 0.001)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        /// <summary>
        /// Adds two rows of the matrix, after multiplying each by the appropriate 
        /// scalar, so that the leading coefficient of one of the rows will be eliminated.
        /// </summary>
        /// <param name="sourceRow">The row who will be used to eliminated the 
        /// leading coefficient of the destRow.</param>
        /// <param name="destRow">The row whose leading coefficient will be eliminated.</param>
        /// <param name="scalar"></param>
        public void RowAddScalar1(int sourceRow, int destRow, double[] scalar)
        {
            if (Math.Abs(scalar[0]) < .001)
            {
                return;
            }
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                matrix[destRow, i] = matrix[sourceRow, i] * scalar[1] - matrix[destRow, i] * scalar[0];
            }
            return;
        }

        /// <summary>
        /// Determines the greatest common denominator of an entire row of the matrix.
        /// </summary>
        /// <param name="pos">The index of the matrix whose gcd is sought.</param>
        /// <returns>Returns the value of the gcd of a row of the matrix.</returns>
        public double GCDofRow(int pos)
        {
            double gcd = matrix[pos, 0];
            for (int i = 1; i < matrix.GetLength(1); i++)
            {
                gcd = GCD(matrix[pos, i], gcd);
            }
            return gcd;
        }

        /// <summary>
        /// Reduces a row to the lowest integer terms.
        /// </summary>
        /// <param name="pos">The index of the row to be reduced to lowest terms.</param>
        public void ToLowestTermsR(int pos)
        {
            double gcd = GCDofRow(pos);
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (Math.Abs(matrix[pos, i]) > .001)
                {
                    matrix[pos, i] /= gcd;
                }
            }
        }

        /// <summary>
        /// Determines the signs of the leading coefficients of each row in the matrix.
        /// </summary>
        /// <returns>Returs an array indicating the signs of the rows in the array.</returns>
        public int[] GetSigns()
        {
            int[] signs = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (Math.Abs(matrix[i, j]) > .001 && matrix[i, j] > 0)
                    {
                        signs[i] = 1;
                        break;
                    }
                    else if (Math.Abs(matrix[i, j]) > .001 && matrix[i, j] < 0)
                    {
                        signs[i] = -1;
                        break;
                    }
                }
            }

            return signs;
        }

        /// <summary>
        /// Ensures that the leading coefficients of each row are positve and that
        /// the remaining values in the row are properly adjusted as well.
        /// </summary>
        public void ToPositive()
        {
            int[] signs = GetSigns();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] * signs[i];
                }
            }

        }

        /// <summary>
        /// Reduces the entire matrix to the lowest integer terms.
        /// </summary>
        public void ToLowestTermsM()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                ToLowestTermsR(i);
            }
        }

        /// <summary>
        /// Solves a matrix by performing Gaussian Elimination and then calling
        /// a separate function that performs Gauss-Jordan Elimination.
        /// </summary>
        /// <returns>Returns the matrix solved through Gauss-Jordan Elimination.</returns>
        //static double[,] ToRowEchelonForm(double[,] matrix)
        public double[,] SolveMatrix()
        {
            double[] scalar1;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                FindAndSwap(i);
                for (int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    ToLowestTermsM();
                    ToPositive();
                    //Console.WriteLine("I " + i + " j " + j);
                    //Console.WriteLine("FIRST");
                    //DisplayMatrix();
                    scalar1 = FindScalars(i, j);
                    //Console.WriteLine("Sclar " + scalar);
                    RowAddScalar1(i, j, scalar1);
                    //Console.WriteLine("LAST");
                    //DisplayMatrix();
                }
            }
            ToLowestTermsM();
            ToPositive();
            //Console.WriteLine("\n//////////////////////////////////////////////////////////\n");
            //DisplayMatrix();
            //Console.WriteLine("\n//////////////////////////////////////////////////////////\n");
            ToRedRowEchelon();
            ToLowestTermsM();
            ToPositive();
            return matrix;
        }

        /// <summary>
        /// Determines the scalars of particular positions in the matrix for use in 
        /// reducing the matrix in Gauss-Jordan Elimination.
        /// </summary>
        /// <param name="bottomRow">The index of the bottom row whose scalar is sought.</param>
        /// <param name="topRow">The index of the top row whose scalar is sought.</param>
        /// <returns>Returns an array containg the scalars of particular positions in the 
        /// matrix for use in reducing the matrix in Gauss-Jordan Elimination</returns>
        public double[] FindPositionalScalars(int bottomRow, int topRow)
        {
            double[] scalars = new double[2];
            scalars[0] = matrix[bottomRow, bottomRow];
            scalars[1] = matrix[topRow, bottomRow];
            return scalars;
        }

        /// <summary>
        /// Performs Gauss-Jordan Elmination on the matrix.
        /// </summary>
        private void ToRedRowEchelon()
        {
            double[] scalar1;
            //Console.WriteLine("CALLED RED" + numElems);

            for (int i = 0; i < numElems; i++)
            {
                FindAndSwap(i);
                //Console.WriteLine("FS" + i);
                //DisplayMatrix();
            }

            for (int i = left.Length + right.Length - 1; i >= 0; i--)
            //for (int i = matrix.GetLength(0) - 1; i >= 0; i--)
            {
                FindAndSwap(i);
                for (int j = i - 1; j >= 0; j--)
                {
                    ToLowestTermsM();
                    ToPositive();
                    //Console.WriteLine("\nI " + i + " j " + j);
                    //Console.WriteLine("RED");
                    //Console.WriteLine("I "+ i + " j " + j);
                    //DisplayMatrix();
                    scalar1 = FindPositionalScalars(i, j);
                    //Console.WriteLine("Sclar " + scalar1[0] + " " + scalar1[1]);
                    RowAddScalar1(i, j, scalar1);
                    //Console.WriteLine("LAST");
                    //DisplayMatrix();

                }
            }
        }

        /// <summary>
        /// Displays the values in the matrix.
        /// </summary>
        public void DisplayMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Returns a string representation of the matrix arranged in a 2-D array fashion.
        /// </summary>
        /// <returns>Returns a string representation of the matrix arranged in a 2-D array fashion.</returns>
        public string ToStringArranged()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s.Append(matrix[i, j]);
                    s.Append(" ");
                }
                s.Append("\n");
            }
            return s.ToString();
        }

        /// <summary>
        /// Returns a string representation of the matrix in a single line fashion.
        /// </summary>
        /// <returns>Returns a string representation of the matrix in a single line fashion.</returns>
        public string ToString()
        {
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    s.Append(matrix[i, j]);
                    s.Append(" ");
                }
                //s.Append("\n");
            }
            return s.ToString();
        }
    }
}