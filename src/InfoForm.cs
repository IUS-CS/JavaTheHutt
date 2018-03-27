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

        public void Add(List<String> data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                InfoBox.Text += data.ElementAt(i) + Environment.NewLine;
            }
        }
    }
}
