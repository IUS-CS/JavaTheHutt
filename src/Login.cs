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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            String username = UserNameBox.Text;
            String passphrase = PassphraseBox.Text;

            if (true) // if(passphrase == user.passphrase)
            {
                KSY browser = new KSY();
                this.Hide();
                browser.ShowDialog();
                this.Close();
            }
        }
    }
}
