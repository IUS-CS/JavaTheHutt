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
    public partial class FunctionEval : Form
    {
        public FunctionEval()
        {
            InitializeComponent();
        }

        private void buttonEval_Click(object sender, EventArgs e)
        {           
            try
            {
                labelResult.Text = "f(" + VarBox.Text + ") = " + Evaluate(FunctionBox.Text, Double.Parse(VarBox.Text));
            }
            catch(Exception ex)
            {
                labelResult.Text = ex.ToString();
            }
        }
        public double Evaluate(String expression, double value)
        {
            Calculator calc = new Calculator();

            return calc.Compute(expression.Replace("x", value.ToString()));
        }
    }
}
