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
    public partial class EulerForm : Form
    {
        public EulerForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Responds to button click by pulling data from text boxes and calling appropriate method
        /// </summary>
        /// <param name="sender">The object that send the event argument.</param>
        /// <param name="e">The event argument.</param>
        private void EulerButton_Click(object sender, EventArgs e)
        {
            FunctionEval func = new FunctionEval();

            try
            {
                if (!string.IsNullOrEmpty(FunctionBox.Text) && !string.IsNullOrEmpty(InitialPointBox.Text) && !string.IsNullOrEmpty(EndValueBox.Text))
                {
                    String[] values = InitialPointBox.Text.Replace("(", "").Replace(")", "").Split(',');
                    double x = Double.Parse(values[0].Trim());
                    double y = Double.Parse(values[1].Trim());

                    if (this.Text == "Euler's Method")
                    {
                        ResultBox.Text = func.Euler(FunctionBox.Text, x, y, Double.Parse(EndValueBox.Text)).ToString();
                    }
                    else if (this.Text == "Heun's Method")
                    {
                        ResultBox.Text = func.Heun(FunctionBox.Text, x, y, Double.Parse(EndValueBox.Text)).ToString();
                    }
                }
                else
                {
                    ResultBox.Text = "All data required";
                }
            }
            catch(Exception ex)
            {
                ResultBox.Text = "Error: " + ex;
            }           
        }
    }
}
