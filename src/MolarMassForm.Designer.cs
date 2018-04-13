namespace Browser
{
    partial class MolarMassForm
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
            this.MassBox = new System.Windows.Forms.TextBox();
            this.MolarMassButton = new System.Windows.Forms.Button();
            this.ElementBox = new System.Windows.Forms.TextBox();
            this.MolarResultBox = new System.Windows.Forms.TextBox();
            this.MassLabel = new System.Windows.Forms.Label();
            this.ElementLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MassBox
            // 
            this.MassBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MassBox.Location = new System.Drawing.Point(71, 128);
            this.MassBox.MaxLength = 25;
            this.MassBox.Name = "MassBox";
            this.MassBox.Size = new System.Drawing.Size(82, 20);
            this.MassBox.TabIndex = 0;
            // 
            // MolarMassButton
            // 
            this.MolarMassButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MolarMassButton.Location = new System.Drawing.Point(106, 208);
            this.MolarMassButton.Name = "MolarMassButton";
            this.MolarMassButton.Size = new System.Drawing.Size(75, 23);
            this.MolarMassButton.TabIndex = 1;
            this.MolarMassButton.Text = "Compute";
            this.MolarMassButton.UseVisualStyleBackColor = true;
            this.MolarMassButton.Click += new System.EventHandler(this.MolarMassButton_Click);
            // 
            // ElementBox
            // 
            this.ElementBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ElementBox.Location = new System.Drawing.Point(181, 128);
            this.ElementBox.MaxLength = 2;
            this.ElementBox.Name = "ElementBox";
            this.ElementBox.Size = new System.Drawing.Size(37, 20);
            this.ElementBox.TabIndex = 2;
            // 
            // MolarResultBox
            // 
            this.MolarResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MolarResultBox.Location = new System.Drawing.Point(95, 60);
            this.MolarResultBox.Name = "MolarResultBox";
            this.MolarResultBox.ReadOnly = true;
            this.MolarResultBox.Size = new System.Drawing.Size(100, 20);
            this.MolarResultBox.TabIndex = 3;
            this.MolarResultBox.TabStop = false;
            // 
            // MassLabel
            // 
            this.MassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MassLabel.AutoSize = true;
            this.MassLabel.Location = new System.Drawing.Point(68, 112);
            this.MassLabel.Name = "MassLabel";
            this.MassLabel.Size = new System.Drawing.Size(47, 13);
            this.MassLabel.TabIndex = 4;
            this.MassLabel.Text = "Mass (g)";
            // 
            // ElementLabel
            // 
            this.ElementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ElementLabel.AutoSize = true;
            this.ElementLabel.Location = new System.Drawing.Point(178, 112);
            this.ElementLabel.Name = "ElementLabel";
            this.ElementLabel.Size = new System.Drawing.Size(45, 13);
            this.ElementLabel.TabIndex = 5;
            this.ElementLabel.Text = "Element";
            // 
            // MolarMassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.ElementLabel);
            this.Controls.Add(this.MassLabel);
            this.Controls.Add(this.MolarResultBox);
            this.Controls.Add(this.ElementBox);
            this.Controls.Add(this.MolarMassButton);
            this.Controls.Add(this.MassBox);
            this.Name = "MolarMassForm";
            this.Text = "Molar Mass";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox MassBox;
        private System.Windows.Forms.Button MolarMassButton;
        private System.Windows.Forms.TextBox ElementBox;
        private System.Windows.Forms.TextBox MolarResultBox;
        private System.Windows.Forms.Label MassLabel;
        private System.Windows.Forms.Label ElementLabel;
    }
}