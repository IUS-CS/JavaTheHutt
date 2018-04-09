using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    class FunctionEval
    {
        double step = .0001;

        /// <summary>
        /// Formats expression and substitutes value for variable, then computes result
        /// </summary>
        /// <param name="expression">The string that represents the expression to be evaluated.</param>
        /// <param name="value">The value that the expression will be evaluted at.</param>
        /// <returns>Returns the result of Compute_Recursion(expression).</returns>
        public double Evaluate(String expression, double value)
        {
            expression = Format(expression);
            expression = expression.Replace("x", value.ToString());

            return Compute_Recursion(expression);
        }

        /// <summary>
        /// Formats expression and computes result
        /// </summary>
        /// <param name="expression">The string that represents the expression to be evaluated.</param>
        /// <returns>Returns the result of Compute_Recursion(Format(expression)).</returns>
        public double Evaluate(String expression)
        {
            return Compute_Recursion(Format(expression));
        }

        /// <summary>
        /// Recursively breaks down expression string until final result can be returned
        /// </summary>
        /// <param name="CurrentResult">The string that represents the expression to be evaluated.</param>
        /// <returns>A recursive call to Compute_Recursion or the final result if at the base case.</returns>
        private double Compute_Recursion(String CurrentResult)
        {
            int index;

            if (!CurrentResult.Contains('*') && !CurrentResult.Contains('/') && !CurrentResult.Contains('+') && !CurrentResult.Contains('-') && !CurrentResult.Contains('^'))
            {
                return Double.Parse(CurrentResult);
            }
            else if (CurrentResult.Contains('+'))
            {
                index = CurrentResult.IndexOf('+');

                return Compute_Recursion(CurrentResult.Substring(0, index)) + Compute_Recursion(CurrentResult.Substring(index + 1, CurrentResult.Length - (index + 1)));
            }
            else if (CurrentResult.Contains('-'))
            {
                index = CurrentResult.IndexOf('-');

                return Compute_Recursion(CurrentResult.Substring(0, index)) - Compute_Recursion(CurrentResult.Substring(index + 1, CurrentResult.Length - (index + 1)));
            }
            else if (CurrentResult.Contains('*'))
            {
                index = CurrentResult.IndexOf('*');

                return Compute_Recursion(CurrentResult.Substring(0, index)) * Compute_Recursion(CurrentResult.Substring(index + 1, CurrentResult.Length - (index + 1)));
            }
            else if (CurrentResult.Contains('/'))
            {
                index = CurrentResult.IndexOf('/');

                return Compute_Recursion(CurrentResult.Substring(0, index)) / Compute_Recursion(CurrentResult.Substring(index + 1, CurrentResult.Length - (index + 1)));
            }
            else
            {
                index = CurrentResult.IndexOf('^');

                return Math.Pow(Compute_Recursion(CurrentResult.Substring(0, index)), Compute_Recursion(CurrentResult.Substring(index + 1, CurrentResult.Length - (index + 1))));
            }
        }

        /// <summary>
        /// Replaces numeric characters and pre-evaluates expression with parentheses
        /// </summary>
        /// <param name="expression">The string that represents the expression to be formated.</param>
        /// <returns>The input expression after formatting.</returns>
        private String Format(String expression)
        {
            int index1;
            int index2;

            expression = expression.Replace("e", Math.E.ToString()).Replace("𝜋", Math.PI.ToString());

            while (expression.Contains("("))
            {
                index1 = expression.LastIndexOf('(');
                String firstPart = expression.Substring(0, index1);
                String lastPart = expression.Substring(index1, expression.Length - index1);
                index2 = lastPart.IndexOf(')') + firstPart.Length;

                expression = expression.Substring(0, index1) + Compute_Recursion(expression.Substring(index1 + 1, index2 - (index1 + 1)) + expression.Substring(index2 + 1, expression.Length - (index2 + 1)));
            }
            return expression;
        }

        /// <summary>
        /// Computes the result of Euler's method on a function with given values
        /// </summary>
        /// <param name="func">The string that represents the function to be computed.</param>
        /// <param name="x">The initial x coordinate.</param>
        /// <param name="y">The initial y coordinate.</param>
        /// <param name="end">The final x value for the function to be evaluated at.</param>
        /// <returns>The value of y once it holds the numberic integral of F(x).</returns>
        public double Euler(String func, double x, double y, double end)
        {
            while (x < end)
            {
                y = y + step * Evaluate(func, x);
                x += step;
            }

            return y;
        }

        /// <summary>
        /// Computes the result of Heun's method on a function with given values
        /// </summary>
        /// <param name="func">The string that represents the function to be computed.</param>
        /// <param name="x">The initial x coordinate.</param>
        /// <param name="y">The initial y coordinate.</param>
        /// <param name="end">The final x value for the function to be evaluated at.</param>
        /// <returns>The value of y once it holds the numberic integral of F(x).</returns>
        public double Heun(String func, double x, double y, double end)
        {
            while (x < end)
            {
                y = y + .5 * step * (Evaluate(func, x) + Evaluate(func, x + step));
                x += step;
            }

            return y;
        }
    }
}
