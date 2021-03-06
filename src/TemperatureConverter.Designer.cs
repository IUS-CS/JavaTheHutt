﻿namespace Browser
{
    partial class TemperatureConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FahrenheitLabel = new System.Windows.Forms.Label();
            this.CelsiusLabel = new System.Windows.Forms.Label();
            this.KelvinLabel = new System.Windows.Forms.Label();
            this.RankineLabel = new System.Windows.Forms.Label();
            this.FahrenheitBox = new System.Windows.Forms.TextBox();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.KelvinBox = new System.Windows.Forms.TextBox();
            this.RankineBox = new System.Windows.Forms.TextBox();
            this.Temp_Convert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FahrenheitLabel
            // 
            this.FahrenheitLabel.AutoSize = true;
            this.FahrenheitLabel.Location = new System.Drawing.Point(53, 48);
            this.FahrenheitLabel.Name = "FahrenheitLabel";
            this.FahrenheitLabel.Size = new System.Drawing.Size(57, 13);
            this.FahrenheitLabel.TabIndex = 0;
            this.FahrenheitLabel.Text = "Fahrenheit";
            // 
            // CelsiusLabel
            // 
            this.CelsiusLabel.AutoSize = true;
            this.CelsiusLabel.Location = new System.Drawing.Point(53, 83);
            this.CelsiusLabel.Name = "CelsiusLabel";
            this.CelsiusLabel.Size = new System.Drawing.Size(40, 13);
            this.CelsiusLabel.TabIndex = 1;
            this.CelsiusLabel.Text = "Celsius";
            // 
            // KelvinLabel
            // 
            this.KelvinLabel.AutoSize = true;
            this.KelvinLabel.Location = new System.Drawing.Point(53, 121);
            this.KelvinLabel.Name = "KelvinLabel";
            this.KelvinLabel.Size = new System.Drawing.Size(36, 13);
            this.KelvinLabel.TabIndex = 2;
            this.KelvinLabel.Text = "Kelvin";
            // 
            // RankineLabel
            // 
            this.RankineLabel.AutoSize = true;
            this.RankineLabel.Location = new System.Drawing.Point(53, 163);
            this.RankineLabel.Name = "RankineLabel";
            this.RankineLabel.Size = new System.Drawing.Size(47, 13);
            this.RankineLabel.TabIndex = 3;
            this.RankineLabel.Text = "Rankine";
            // 
            // FahrenheitBox
            // 
            this.FahrenheitBox.Location = new System.Drawing.Point(136, 48);
            this.FahrenheitBox.MaxLength = 100;
            this.FahrenheitBox.Name = "FahrenheitBox";
            this.FahrenheitBox.Size = new System.Drawing.Size(100, 20);
            this.FahrenheitBox.TabIndex = 0;
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(136, 83);
            this.CelsiusBox.MaxLength = 100;
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(100, 20);
            this.CelsiusBox.TabIndex = 1;
            // 
            // KelvinBox
            // 
            this.KelvinBox.Location = new System.Drawing.Point(136, 121);
            this.KelvinBox.MaxLength = 100;
            this.KelvinBox.Name = "KelvinBox";
            this.KelvinBox.Size = new System.Drawing.Size(100, 20);
            this.KelvinBox.TabIndex = 2;
            // 
            // RankineBox
            // 
            this.RankineBox.Location = new System.Drawing.Point(136, 163);
            this.RankineBox.MaxLength = 100;
            this.RankineBox.Name = "RankineBox";
            this.RankineBox.Size = new System.Drawing.Size(100, 20);
            this.RankineBox.TabIndex = 3;
            // 
            // Temp_Convert
            // 
            this.Temp_Convert.Location = new System.Drawing.Point(103, 213);
            this.Temp_Convert.Name = "Temp_Convert";
            this.Temp_Convert.Size = new System.Drawing.Size(75, 23);
            this.Temp_Convert.TabIndex = 4;
            this.Temp_Convert.Text = "Convert";
            this.Temp_Convert.UseVisualStyleBackColor = true;
            this.Temp_Convert.Click += new System.EventHandler(this.Temp_Convert_Click);
            // 
            // TemperatureConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Temp_Convert);
            this.Controls.Add(this.RankineBox);
            this.Controls.Add(this.KelvinBox);
            this.Controls.Add(this.CelsiusBox);
            this.Controls.Add(this.FahrenheitBox);
            this.Controls.Add(this.RankineLabel);
            this.Controls.Add(this.KelvinLabel);
            this.Controls.Add(this.CelsiusLabel);
            this.Controls.Add(this.FahrenheitLabel);
            this.Name = "TemperatureConverter";
            this.Text = "Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FahrenheitLabel;
        private System.Windows.Forms.Label CelsiusLabel;
        private System.Windows.Forms.Label KelvinLabel;
        private System.Windows.Forms.Label RankineLabel;
        private System.Windows.Forms.TextBox FahrenheitBox;
        private System.Windows.Forms.TextBox CelsiusBox;
        private System.Windows.Forms.TextBox KelvinBox;
        private System.Windows.Forms.TextBox RankineBox;
        private System.Windows.Forms.Button Temp_Convert;
    }
}