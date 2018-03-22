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
            if (!string.IsNullOrEmpty(FahrenheitBox.Text))
            {
                double fahrenheit = Double.Parse(FahrenheitBox.Text);
                double celsius = (fahrenheit - 32) * (5 / 9.0);

                CelsiusBox.Text = celsius.ToString();
                KelvinBox.Text =  (celsius + 273.15).ToString();
                RankineBox.Text = (fahrenheit + 459.67).ToString();
            }
            else if (!string.IsNullOrEmpty(CelsiusBox.Text))
            {
                double celsius = Double.Parse(CelsiusBox.Text);
                double fahrenheit = celsius * (9 / 5.0) + 32;

                FahrenheitBox.Text = fahrenheit.ToString();
                KelvinBox.Text = (celsius + 273.15).ToString();
                RankineBox.Text = (fahrenheit + 459.67).ToString();
            }
            else if (!string.IsNullOrEmpty(KelvinBox.Text))
            {
                double kelvin = Double.Parse(KelvinBox.Text);
                double celsius = kelvin - 273.15;
                double fahrenheit = celsius * (9 / 5.0) + 32;

                CelsiusBox.Text = celsius.ToString();
                FahrenheitBox.Text =  (celsius * (9 / 5.0) + 32).ToString();
                if (kelvin == 0)
                {
                    RankineBox.Text =  "0";
                }
                else
                {
                    RankineBox.Text = (fahrenheit + 459.67).ToString();
                }
            }
            else if (!string.IsNullOrEmpty(RankineBox.Text))
            {
                double rankine = Double.Parse(RankineBox.Text);
                double fahrenheit = rankine - 459.67;
                double celsius = (fahrenheit - 32) * (5 / 9.0);

                FahrenheitBox.Text = fahrenheit.ToString();
                CelsiusBox.Text = celsius.ToString();
                if (rankine == 0)
                {
                    KelvinBox.Text = "0";
                }
                else
                {
                    KelvinBox.Text = (celsius + 273.15).ToString();
                }
            }
        }
    }
}
