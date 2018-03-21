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
    public partial class TemperatureConverter : Form
    {
        public TemperatureConverter()
        {
            InitializeComponent();
        }

        private void Temp_Convert_Click(object sender, EventArgs e)
        {
            if (FahrenheitLabel.Text.CompareTo("") != 1)
            {
                double fahrenheit = Double.Parse(FahrenheitLabel.Text);
                double celsius = (fahrenheit - 32) * (5 / 9);

                CelsiusLabel.Text = celsius.ToString();
                KelvinLabel.Text =  (celsius + 273.15).ToString();
                RankineLabel.Text = (fahrenheit + 459.67).ToString();
            }
            else if (CelsiusLabel.Text.CompareTo("") != 1)
            {
                double celsius = Double.Parse(CelsiusLabel.Text);
                double fahrenheit = celsius * (9 / 5) + 32;

                FahrenheitLabel.Text = fahrenheit.ToString();
                KelvinLabel.Text = (celsius + 273.15).ToString();
                RankineLabel.Text = (fahrenheit + 459.67).ToString();
            }
            else if (KelvinLabel.Text.CompareTo("") != 1)
            {
                double kelvin = Double.Parse(KelvinLabel.Text);
                double celsius = kelvin - 273.15;
                double fahrenheit = celsius * (9 / 5) + 32;

                CelsiusLabel.Text = celsius.ToString();
                FahrenheitLabel.Text =  (celsius * (9 / 5) + 32).ToString();
                if (kelvin == 0)
                {
                    RankineLabel.Text =  "0";
                }
                else
                {
                    RankineLabel.Text = (fahrenheit + 459.67).ToString();
                }
            }
            else if (RankineLabel.Text.CompareTo("") != 1)
            {
                double rankine = Double.Parse(RankineLabel.Text);
                double fahrenheit = rankine - 459.67;
                double celsius = (fahrenheit - 32) * (5 / 9);

                FahrenheitLabel.Text = fahrenheit.ToString();
                CelsiusLabel.Text = celsius.ToString();
                if (rankine == 0)
                {
                    KelvinLabel.Text = "0";
                }
                else
                {
                    KelvinLabel.Text = (celsius + 273.15).ToString();
                }
            }
        }
    }
}
