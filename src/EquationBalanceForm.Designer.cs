namespace Browser
{
    partial class EquationBalanceForm
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
            this.BalancedBox = new System.Windows.Forms.TextBox();
            this.ChemicalStringBox = new System.Windows.Forms.TextBox();
            this.Balancebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BalancedBox
            // 
            this.BalancedBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BalancedBox.Location = new System.Drawing.Point(67, 59);
            this.BalancedBox.Name = "BalancedBox";
            this.BalancedBox.ReadOnly = true;
            this.BalancedBox.Size = new System.Drawing.Size(147, 20);
            this.BalancedBox.TabIndex = 1;
            this.BalancedBox.TabStop = false;
            // 
            // ChemicalStringBox
            // 
            this.ChemicalStringBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChemicalStringBox.Location = new System.Drawing.Point(67, 115);
            this.ChemicalStringBox.Name = "ChemicalStringBox";
            this.ChemicalStringBox.Size = new System.Drawing.Size(147, 20);
            this.ChemicalStringBox.TabIndex = 0;
            // 
            // Balancebutton
            // 
            this.Balancebutton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Balancebutton.Location = new System.Drawing.Point(99, 216);
            this.Balancebutton.Name = "Balancebutton";
            this.Balancebutton.Size = new System.Drawing.Size(75, 23);
            this.Balancebutton.TabIndex = 2;
            this.Balancebutton.Text = "Balance";
            this.Balancebutton.UseVisualStyleBackColor = true;
            this.Balancebutton.Click += new System.EventHandler(this.Balancebutton_Click);
            // 
            // EquationBalanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Balancebutton);
            this.Controls.Add(this.ChemicalStringBox);
            this.Controls.Add(this.BalancedBox);
            this.Name = "EquationBalanceForm";
            this.Text = "Equation Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BalancedBox;
        private System.Windows.Forms.TextBox ChemicalStringBox;
        private System.Windows.Forms.Button Balancebutton;
    }
}