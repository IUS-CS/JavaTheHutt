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
    public partial class EquationBalanceForm : Form
    {
        public EquationBalanceForm()
        {
            InitializeComponent();
        }

        private void Balancebutton_Click(object sender, EventArgs e)
        {
            ChemEqnMatrix ChemicalString = new ChemEqnMatrix(ChemicalStringBox.Text);

            BalancedBox.Text = ChemicalString.Balance();
        }
    }
}
