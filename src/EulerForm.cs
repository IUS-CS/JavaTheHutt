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

        private void EulerButton_Click(object sender, EventArgs e)
        {
            FunctionEval func = new FunctionEval();

            try
            {
                String[] values = InitialPointBox.Text.Split(',');
                double x = Double.Parse(values[0].Trim());
                double y = Double.Parse(values[1].Trim());

                ResultBox.Text = func.Euler(FunctionBox.Text, x, y, Double.Parse(EndValueBox.Text)).ToString();
            }
            catch(Exception ex)
            {
                ResultBox.Text = "Error: " + ex;
            }           
        }
    }
}
