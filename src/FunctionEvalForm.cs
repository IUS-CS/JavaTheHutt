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
    public partial class FunctionEvalForm : Form
    {
        public FunctionEvalForm()
        {
            InitializeComponent();
        }

        private void buttonEval_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FunctionBox.Text))
            {
                labelResult.Text = "Function box is empty";
            }
            else if (string.IsNullOrEmpty(VarBox.Text))
            {
                labelResult.Text = "Variable box is empty";
            }
            else {
                try
                {
                    FunctionEval func = new FunctionEval();

                    labelResult.Text = "f(" + VarBox.Text + ") = " + func.Evaluate(FunctionBox.Text, Double.Parse(VarBox.Text));
                }
                catch (Exception ex)
                {
                    labelResult.Text = ex.ToString();
                }
            }
        }
    }
}
