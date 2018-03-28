namespace Browser
{
    partial class EulerForm
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
            this.FunctionBox = new System.Windows.Forms.TextBox();
            this.InitialPointBox = new System.Windows.Forms.TextBox();
            this.EndValueBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Eulerlabel2 = new System.Windows.Forms.Label();
            this.Eulerlabel3 = new System.Windows.Forms.Label();
            this.ResultBox = new System.Windows.Forms.TextBox();
            this.EulerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FunctionBox
            // 
            this.FunctionBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FunctionBox.Location = new System.Drawing.Point(84, 69);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(100, 20);
            this.FunctionBox.TabIndex = 0;
            // 
            // InitialPointBox
            // 
            this.InitialPointBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InitialPointBox.Location = new System.Drawing.Point(84, 107);
            this.InitialPointBox.Name = "InitialPointBox";
            this.InitialPointBox.Size = new System.Drawing.Size(100, 20);
            this.InitialPointBox.TabIndex = 1;
            // 
            // EndValueBox
            // 
            this.EndValueBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EndValueBox.Location = new System.Drawing.Point(84, 146);
            this.EndValueBox.Name = "EndValueBox";
            this.EndValueBox.Size = new System.Drawing.Size(100, 20);
            this.EndValueBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "f\'(x,y) =";
            // 
            // Eulerlabel2
            // 
            this.Eulerlabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eulerlabel2.AutoSize = true;
            this.Eulerlabel2.Location = new System.Drawing.Point(16, 110);
            this.Eulerlabel2.Name = "Eulerlabel2";
            this.Eulerlabel2.Size = new System.Drawing.Size(62, 13);
            this.Eulerlabel2.TabIndex = 4;
            this.Eulerlabel2.Text = "(x_0, y_0) =";
            // 
            // Eulerlabel3
            // 
            this.Eulerlabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eulerlabel3.AutoSize = true;
            this.Eulerlabel3.Location = new System.Drawing.Point(30, 149);
            this.Eulerlabel3.Name = "Eulerlabel3";
            this.Eulerlabel3.Size = new System.Drawing.Size(45, 13);
            this.Eulerlabel3.TabIndex = 5;
            this.Eulerlabel3.Text = "x_end =";
            // 
            // ResultBox
            // 
            this.ResultBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ResultBox.Location = new System.Drawing.Point(84, 21);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.ReadOnly = true;
            this.ResultBox.Size = new System.Drawing.Size(100, 20);
            this.ResultBox.TabIndex = 6;
            // 
            // EulerButton
            // 
            this.EulerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EulerButton.Location = new System.Drawing.Point(96, 211);
            this.EulerButton.Name = "EulerButton";
            this.EulerButton.Size = new System.Drawing.Size(75, 23);
            this.EulerButton.TabIndex = 7;
            this.EulerButton.Text = "Compute";
            this.EulerButton.UseVisualStyleBackColor = true;
            this.EulerButton.Click += new System.EventHandler(this.EulerButton_Click);
            // 
            // EulerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.EulerButton);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.Eulerlabel3);
            this.Controls.Add(this.Eulerlabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EndValueBox);
            this.Controls.Add(this.InitialPointBox);
            this.Controls.Add(this.FunctionBox);
            this.Name = "EulerForm";
            this.Text = "Euler\'s Method";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FunctionBox;
        private System.Windows.Forms.TextBox InitialPointBox;
        private System.Windows.Forms.TextBox EndValueBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Eulerlabel2;
        private System.Windows.Forms.Label Eulerlabel3;
        private System.Windows.Forms.TextBox ResultBox;
        private System.Windows.Forms.Button EulerButton;
    }
}