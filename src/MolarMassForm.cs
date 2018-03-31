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
    public partial class MolarMassForm : Form
    {
        public MolarMassForm()
        {
            InitializeComponent();
        }

        private void MolarMassButton_Click(object sender, EventArgs e) // TODO
        {
            double data = 1;

            try
            {
                MolarResultBox.Text = (Double.Parse(MassBox.Text) / data).ToString();
            }
            catch
            {
                MolarResultBox.Text = "Error";
            }
        }
    }
}
