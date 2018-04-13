using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class Calculator : Form
    {
        String result; //stores the math string as it is built

        public Calculator()
        {
            InitializeComponent();
            result = "";
        }

        /// <summary>
        /// Appends a "0" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonZero_Click(object sender, EventArgs e)
        {
            result += "0";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "1" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button1_Click(object sender, EventArgs e)
        {
            result += "1";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "2" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button2_Click(object sender, EventArgs e)
        {
            result += "2";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "3" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button3_Click(object sender, EventArgs e)
        {
            result += "3";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "4" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button4_Click(object sender, EventArgs e)
        {
            result += "4";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "5" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button5_Click(object sender, EventArgs e)
        {
            result += "5";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "6" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button6_Click(object sender, EventArgs e)
        {
            result += "6";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "7" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button7_Click(object sender, EventArgs e)
        {
            result += "7";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "8" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button8_Click(object sender, EventArgs e)
        {
            result += "8";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "9" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void button9_Click(object sender, EventArgs e)
        {
            result += "9";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "+" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonPlus_Click(object sender, EventArgs e)
        {
            result += "+";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "-" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            result += "-";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "*" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonMult_Click(object sender, EventArgs e)
        {
            result += "*";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "/" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonDiv_Click(object sender, EventArgs e)
        {
            result += "/";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "^" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonPow_Click(object sender, EventArgs e)
        {
            result += "^";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "." to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            result += ".";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "(" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonOpenParen_Click(object sender, EventArgs e)
        {
            result += "(";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a ")" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonCloseParen_Click(object sender, EventArgs e)
        {
            result += ")";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "e" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void eButton_Click(object sender, EventArgs e)
        {
            result += "e";
            resultBox.Text = result;
        }

        /// <summary>
        /// Appends a "𝜋" to the end of the math string held in the variable "result" and puts "result" in text box
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonPI_Click(object sender, EventArgs e)
        {
            result += "𝜋";
            resultBox.Text = result;
        }

        /// <summary>
        /// Removes the last character from the math string in "result"
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (result.Length > 1)
            {
                result = result.Substring(0, result.Length - 1);
                resultBox.Text = result;
            }
            else
            {
                result = "";
                resultBox.Text = result;
            }
        }

        /// <summary>
        /// Clears the contents of the math string in "result"
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            result = "";
            resultBox.Text = result;
        }

        /// <summary>
        /// Performs a function evaluation on the math string that has been built prior to this method call
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(resultBox.Text))
            {
                try
                {
                    FunctionEval function = new FunctionEval();

                    double result_number = function.Evaluate(result);
                    result = result_number.ToString();
                    resultBox.Text = result;
                }
                catch (Exception ex)
                {
                    resultBox.Text = "Error: " + ex;
                }
            }
        }

        /// <summary>
        /// Performs a function evaluation on the math string that has been built prior to this method call
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void resultBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                result = resultBox.Text;

                if (!string.IsNullOrEmpty(result))
                {
                    try
                    {
                        FunctionEval function = new FunctionEval();

                        double result_number = function.Evaluate(result);
                        resultBox.Text = result_number.ToString();
                    }
                    catch (Exception ex)
                    {
                        resultBox.Text = "Error: " + ex;
                    }
                }
            }
        }
    }
}
