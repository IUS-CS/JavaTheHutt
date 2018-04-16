using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    /// <summary>
    /// A class largely used for parsing out the terms of an unbalanced chemical equation.
    /// </summary>
    public class Equation
    {
        public List<String> elements = new List<string>();
        static string eqn;

        /// <summary>
        /// Constructs an equation object based on the input string.
        /// </summary>
        /// <param name="s">A string representing a valid, unbalanced chemical equation.</param>
        public Equation(string s)
        {
            eqn = s;
        }

        /// <summary>
        /// Determines the right side of an equation.
        /// </summary>
        /// <returns>Returns a string array containing each of the separate
        /// terms in the right-hand side of the equation.</returns>
        public String[] GetRight()
        {
            string temp;
            temp = eqn.Substring(eqn.IndexOf("=") + 1);
            int numPlus = NumOcc(temp, "+");
            string[] s = new string[numPlus + 1];
            temp = temp.Trim();
            s = temp.Split('+');
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].Trim();
            }
            return s;
        }

        /// <summary>
        /// Determines the left side of an equation.
        /// </summary>
        /// <returns>Returns a string array containing each of the separate
        /// terms in the left-hand side of the equation.</returns>
        public String[] GetLeft()
        {
            string temp;
            temp = eqn.Substring(0, eqn.IndexOf("="));
            int numPlus = NumOcc(temp, "+");
            string[] s = new string[numPlus + 1];
            temp = temp.Trim();
            s = temp.Split('+');
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].Trim();
            }
            return s;
        }

        /// <summary>
        /// Determines the number of times that a particualar sequence of characters 
        /// appears in a larger string.
        /// </summary>
        /// <param name="s">The string which may contain other particular substrings.</param>
        /// <param name="c">The substring of interest.</param>
        /// <returns>Returns the number of times that a substring appears in a larger string.</returns>
        public int NumOcc(string s, string c)
        {
            int count = 0;
		  char temp = Char.Parse(c);
            for (int i = 0; i < s.Length; i++)
            {
                if (0 == s.ElementAt(i).CompareTo(temp))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Parses an input string to determine what elements are in it and the number of times
        /// that element appears in it.
        /// </summary>
        /// <param name="eqn">The string containing the elements to be parsed.</param>
        /// <returns>Returns a row array containing the elements on the top row
        /// and the number of times each element appears on the bottom row, directly
        /// beneath its respective element.</returns>
        public string[,] Parse(string eqn)
        {
            char[] chem = eqn.ToCharArray();
            int[] numInChem = new int[eqn.Length];
            string[] elementsUsed = new string[eqn.Length];
            string temp = chem[0].ToString();
            int numElems = 0;
            int digit;

            for (int i = 1; i < eqn.Length; i++)
            {
                if (char.IsLower(chem[i]))
                {
                    temp = temp + chem[i].ToString();
                }
                else if (char.IsDigit(chem[i]))
                {
                    digit = int.Parse(chem[i].ToString());
                    if (i + 1 < chem.Length && char.IsDigit(chem[i + 1]))
                    {
                        digit = digit * 10 + int.Parse(chem[i + 1].ToString());
                        i++;
                    }
                    if (!elementsUsed.Contains(temp))
                    {
                        elementsUsed[numElems++] = temp;
                    }
                    numInChem[indexOf(elementsUsed, temp)] += digit - 1;//to account for sloppy double counting
                    digit = 0;
                }
                else if (char.IsUpper(chem[i]))
                {
                    if (!elementsUsed.Contains(temp))
                    {
                        elementsUsed[numElems++] = temp;
                    }
                    numInChem[indexOf(elementsUsed, temp)]++;
                    temp = chem[i].ToString();
                }
            }
            if (!elementsUsed.Contains(temp)) //Include last element if not already included
            {
                elementsUsed[numElems++] = temp;
            }
            numInChem[indexOf(elementsUsed, temp)]++;

            for (int i = 0; i < numElems; i++)
            {
                if (!elements.Contains(elementsUsed[i]))
                {
                    elements.Add(elementsUsed[i]);
                }
            }

            String[,] result = new String[2, numElems];
            for (int i = 0; i < numElems; i++)
            {
                result[0, i] = elementsUsed[i];
            }
            for (int i = 0; i < numElems; i++)
            {
                result[1, i] = numInChem[indexOf(elementsUsed, elementsUsed[i])].ToString();
            }

            return result;
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
    }
}