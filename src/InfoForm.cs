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
    public partial class InfoForm : Form
    {
        public InfoForm()
        {
            InitializeComponent();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {

        }

        List<String> info = new List<String>();

        public String Print()
        {
            string output = "";

            for(int i = 0; i < info.Count; i++)
            {
                output += info.ElementAt(i) + "\n";
            }
            return output;
        }

        public void Add(String data)
        {
            info.Add(data);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
