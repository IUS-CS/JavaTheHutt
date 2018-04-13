using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Browser
{
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Takes a list as an argument and adds its contents line by line to the InfoForm
        /// </summary>
        /// <param name="data">A List of Strings the should be displayed to the InfoForm's text information</param>
        public void Add(List<String> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                InfoBox.Text += data.ElementAt(i) + Environment.NewLine;
            }
        }
    }
}
