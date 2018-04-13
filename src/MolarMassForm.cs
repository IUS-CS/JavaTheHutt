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

        /// <summary>
        /// Takes the mass supplied to MassBox and computes the number of moles of that element
        /// </summary>
        /// <param name="sender">The sender that sent the event argument</param>
        /// <param name="e">The event argument</param>
        private void MolarMassButton_Click(object sender, EventArgs e) // TODO
        {
            double data = 1;

            if (!string.IsNullOrEmpty(MassBox.Text))
            {
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
}
