﻿using System;
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
        private String CurrentPage = "";
        private Stack<String> ForwardStack = new Stack<String>();
        private Stack<String> BackStack = new Stack<String>();

        public SK_m_0()
        {
            username = "guest";
            InitializeComponent();
        }

        public SK_m_0(String name)
        {
            username = name;
            InitializeComponent();
        }

        private void WebSearch_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(URLBox.Text))
            {
                URLControler(URLBox.Text);
            }
        }

        private void URLBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                URLControler(URLBox.Text);
            }
        }
        private void URLControler(String url)
        {
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
            }
            else if (url.StartsWith("C:") || url.StartsWith("F:") || url.StartsWith("D:"))
            {
                this.webBrowser1.Url = new Uri(String.Format("file:///{0}", url));
            }
            else
            {
                webBrowser1.Navigate(URLAdjust(url));
            }
        }

        private String URLAdjust(String url)
        {
            if (url.StartsWith("http") && !url.Contains("www."))
            {
                if (url.StartsWith("https"))
                {
                    url = "https://www." + url.Substring(8);
                }
                else
                {
                    url = "http://www." + url.Substring(7);
                }
            }
            if (!url.StartsWith("www.") && !url.StartsWith("http"))
            {
                url = "http://www." + url;
            }
            if (!url.StartsWith("https://") && !url.StartsWith("http://"))
            {
                url = "http://" + url;
            }
            return url;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();

            about.ShowDialog();
            about.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InfoForm user = new InfoForm();

            user.Add("Current User: " + username);
            user.SetText(user.Print());
            user.SetName("User Info");
            user.ShowDialog();
            user.Close();
        }

        private void temperatureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemperatureConverter temp = new TemperatureConverter();

            temp.ShowDialog();
            temp.Close();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();

            calc.ShowDialog();
            calc.Close();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            if (ForwardStack.Count > 0)
            {
                String url = ForwardStack.Pop();
                BackStack.Push(CurrentPage);
                URLBox.Text = url;
                URLControler(url);
            }
        }

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

        private void functionEvalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FunctionEval evaluation = new FunctionEval();
            evaluation.ShowDialog();
            evaluation.Close();
        }

        /*
DataSet ds = new DataSet();
DataTable dt = new DataTable();
SqlConnection conn = new SqlConnection();
//conn.ConnectionString = "User ID=postgres; Password=123; Host=localhost Port=5432; Database=Users; Pooling=true; Min Pool Size=100; Connection Lifetime=0;";
conn.ConnectionString = "Server=postgresql://localhost; User ID=postgres; Password=123; Database=Users;";
conn.Open();

SqlCommand command = new SqlCommand("Select * From user_info", conn);
command.Connection.Open();
command.ExecuteNonQuery();
System.Console.WriteLine(conn.ToString());
*/


    }
}