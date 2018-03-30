using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Browser
{
    class FunctionEval
    {
        public double Evaluate(String expression, double value)
        {
            Format(expression);
            expression.Replace("x", value.ToString());
            return Compute_Recursion(expression);
        }

        public double Evaluate(String input)
        {
            return Compute_Recursion(Format(input));
        }

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
        
        private String Format(String input)
        {

            return input.Replace("e", Math.E.ToString()).Replace("𝜋", Math.PI.ToString());
        }

        public double Euler(String func, double x, double y, double end)
        {
            double step = .0001;

            while (x < end)
            {
                y = y + step * Evaluate(func, x);
                x += step;
            }

            return y;
        }
    }
}
