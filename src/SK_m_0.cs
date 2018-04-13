using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Browser
{
    public partial class SK_m_0 : Form
    {
        String username;
        public Boolean ClipboardEnabled = false; //setting to determine whether results are stored in clipboard
        private String CurrentPage = "";
        private Stack<String> ForwardStack = new Stack<String>(); //a stack that holds webpages visited after the current page
        private Stack<String> BackStack = new Stack<String>(); //a stack that holds previously visited webpages
        private List<String> history = new List<String>(); //a list to store browser history

        public SK_m_0()
        {
            username = "guest"; // "guest" is default if no username is sent from login form. This will occur if login is disabled.
            InitializeComponent();
        }

        public SK_m_0(String name)
        {
            username = name;
            InitializeComponent();
        }

        /// <summary>
        /// Searches for a webpage corresponding to URLBox.Text
        /// </summary>
        private void WebSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URLBox.Text))
            {
                URLControler(URLBox.Text);
            }
        }

        /// <summary>
        /// Calls URLControler if ENTER key is pressed from URLBox
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void URLBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                URLControler(URLBox.Text);
            }
        }

        /// <summary>
        /// Navigates to local file or webpage and maintains the forward and back stacks
        /// </summary>
        /// <param name="url">The url sent for navigation</param>
        private void URLControler(String url)
        {
            history.Add(url);

            if (CurrentPage != "")
            {
                BackStack.Push(CurrentPage);
            }
            CurrentPage = url;

            if (url.StartsWith("l:"))
            {
                string FileName = url.Substring(2);
                string curDir = Directory.GetCurrentDirectory();
                this.webBrowser1.Url = new Uri(String.Format("file:///{0}/{1}", curDir, FileName));

                if (ClipboardEnabled)
                {
                    Clipboard.SetText("file:///" + curDir + " / " + FileName);
                }
            }
            else if (url.StartsWith("C:") || url.StartsWith("F:") || url.StartsWith("D:"))
            {
                this.webBrowser1.Url = new Uri(String.Format("file:///{0}", url));

                if (ClipboardEnabled)
                {
                    Clipboard.SetText("file:///" + url);
                }
            }
            else
            {
                webBrowser1.Navigate(url);

                if (ClipboardEnabled)
                {
                    Clipboard.SetText(url);
                }
            }
        }

        /// <summary>
        /// Creates and shows an about page
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.ShowDialog();
            about.Close();
        }

        /// <summary>
        /// Displays information about the current user that is logged in
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm user = new InfoForm();
            List<String> userList = new List<String>();

            userList.Add("Current User: " + username);
            user.Add(userList);
            user.SetName("User Info");
            user.ShowDialog();
            user.Close();
        }

        /// <summary>
        /// Creates and displays a temperature converter
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemperatureConverter temp = new TemperatureConverter();

            temp.ShowDialog();
            temp.Close();
        }

        /// <summary>
        /// Creates and displays an on-screen calculator
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();

            calc.ShowDialog();
            calc.Close();
        }

        /// <summary>
        /// Navigates to the next page in the forward stack
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (ForwardStack.Count > 0)
            {
                String url = ForwardStack.Pop();
                BackStack.Push(CurrentPage);
                CurrentPage = "";
                URLBox.Text = url;
                URLControler(url);
            }
        }

        /// <summary>
        /// Navigates to the next page in the back stack
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (BackStack.Count > 0)
            {
                String url = BackStack.Pop();
                ForwardStack.Push(CurrentPage);
                URLBox.Text = url;
                CurrentPage = "";
                URLControler(url);
            }
        }

        /// <summary>
        /// Creates and displays a function evaluator
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void functionEvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionEvalForm evaluation = new FunctionEvalForm();
            evaluation.ShowDialog();
            evaluation.Close();
        }

        /// <summary>
        /// Creates an Infoform to display browsing history for the session
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm historyForm = new InfoForm();

            historyForm.Add(history);
            historyForm.SetName("History");
            historyForm.ShowDialog();
            historyForm.Close();
        }

        /// <summary>
        /// Creates and displays a numeric integrator based on Euler's method
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void eulersMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EulerForm ef = new EulerForm();

            ef.ShowDialog();
            ef.Close();
        }

        /// <summary>
        /// Creates and displays a numeric integrator based on Heun's method
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void heunsMethodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EulerForm ef = new EulerForm();

            ef.Text = "Heun's Method";
            ef.ShowDialog();
            ef.Close();
        }

        /// <summary>
        /// Creates and displays a chemical equation balancer
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void chemicalBalancerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquationBalanceForm eq = new EquationBalanceForm();
            eq.ShowDialog();
            eq.Close();
        }

        /// <summary>
        /// Creates and displays a molar mass computer
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void molarMassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MolarMassForm mf = new MolarMassForm();

            mf.ShowDialog();
            mf.Close();
        }

        /// <summary>
        /// Enables clipboard copying when a result is computed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClipboardEnabled = true;
            enableToolStripMenuItem.Enabled = false;
            disableToolStripMenuItem.Enabled = true;

        }

        /// <summary>
        /// Disables clipboard copying when a result is computed
        /// </summary>
        /// <param name="sender">The sender object</param>
        /// <param name="e">The event argument</param>
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClipboardEnabled = false;
            enableToolStripMenuItem.Enabled = true;
            disableToolStripMenuItem.Enabled = false;
        }
    }
}
