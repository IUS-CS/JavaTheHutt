namespace Browser
{
    partial class FunctionEval
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
            this.FunctionLabel = new System.Windows.Forms.Label();
            this.VarLabel = new System.Windows.Forms.Label();
            this.FunctionBox = new System.Windows.Forms.TextBox();
            this.VarBox = new System.Windows.Forms.TextBox();
            this.buttonEval = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FunctionLabel
            // 
            this.FunctionLabel.AutoSize = true;
            this.FunctionLabel.Location = new System.Drawing.Point(68, 121);
            this.FunctionLabel.Name = "FunctionLabel";
            this.FunctionLabel.Size = new System.Drawing.Size(30, 13);
            this.FunctionLabel.TabIndex = 0;
            this.FunctionLabel.Text = "f(x) =";
            // 
            // VarLabel
            // 
            this.VarLabel.AutoSize = true;
            this.VarLabel.Location = new System.Drawing.Point(74, 149);
            this.VarLabel.Name = "VarLabel";
            this.VarLabel.Size = new System.Drawing.Size(24, 13);
            this.VarLabel.TabIndex = 1;
            this.VarLabel.Text = "x = ";
            // 
            // FunctionBox
            // 
            this.FunctionBox.Location = new System.Drawing.Point(104, 118);
            this.FunctionBox.Name = "FunctionBox";
            this.FunctionBox.Size = new System.Drawing.Size(100, 20);
            this.FunctionBox.TabIndex = 2;
            // 
            // VarBox
            // 
            this.VarBox.Location = new System.Drawing.Point(104, 146);
            this.VarBox.Name = "VarBox";
            this.VarBox.Size = new System.Drawing.Size(100, 20);
            this.VarBox.TabIndex = 3;
            // 
            // buttonEval
            // 
            this.buttonEval.Location = new System.Drawing.Point(104, 201);
            this.buttonEval.Name = "buttonEval";
            this.buttonEval.Size = new System.Drawing.Size(75, 23);
            this.buttonEval.TabIndex = 4;
            this.buttonEval.Text = "Compute";
            this.buttonEval.UseVisualStyleBackColor = true;
            this.buttonEval.Click += new System.EventHandler(this.buttonEval_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(119, 68);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(33, 13);
            this.labelResult.TabIndex = 5;
            this.labelResult.Text = "f(x) = ";
            // 
            // FunctionEval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonEval);
            this.Controls.Add(this.VarBox);
            this.Controls.Add(this.FunctionBox);
            this.Controls.Add(this.VarLabel);
            this.Controls.Add(this.FunctionLabel);
            this.Name = "FunctionEval";
            this.Text = "FunctionEval";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FunctionLabel;
        private System.Windows.Forms.Label VarLabel;
        private System.Windows.Forms.TextBox FunctionBox;
        private System.Windows.Forms.TextBox VarBox;
        private System.Windows.Forms.Button buttonEval;
        private System.Windows.Forms.Label labelResult;
    }
}