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
        String result;

        public Calculator()
        {
            InitializeComponent();
            result = "";
        }

        private void buttonZero_Click(object sender, EventArgs e)
        {
            result += "0";
            resultBox.Text = result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            result += "1";
            resultBox.Text = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            result += "2";
            resultBox.Text = result;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            result += "3";
            resultBox.Text = result;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            result += "4";
            resultBox.Text = result;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            result += "5";
            resultBox.Text = result;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            result += "6";
            resultBox.Text = result;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            result += "7";
            resultBox.Text = result;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            result += "8";
            resultBox.Text = result;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            result += "9";
            resultBox.Text = result;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            result += "+";
            resultBox.Text = result;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            result += "-";
            resultBox.Text = result;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            result += "*";
            resultBox.Text = result;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            result += "/";
            resultBox.Text = result;
        }

        private void buttonPow_Click(object sender, EventArgs e)
        {
            result += "^";
            resultBox.Text = result;
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            result += ".";
            resultBox.Text = result;
        }

        private void buttonOpenParen_Click(object sender, EventArgs e)
        {
            result += "(";
            resultBox.Text = result;
        }

        private void buttonCloseParen_Click(object sender, EventArgs e)
        {
            result += ")";
            resultBox.Text = result;
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            result += "e";
            resultBox.Text = result;
        }

        private void buttonPI_Click(object sender, EventArgs e)
        {
            result += "𝜋";
            resultBox.Text = result;
        }
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

        private void buttonClear_Click(object sender, EventArgs e)
        {
            result = "";
            resultBox.Text = result;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            try
            {
                FunctionEval function = new FunctionEval();

                double result_number = function.Evaluate(result);
                result = result_number.ToString();
                resultBox.Text = result;
            }
            catch(Exception ex)
            {
                resultBox.Text = "Error: " + ex;
            }
        }

        private void resultBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                result = resultBox.Text;

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
