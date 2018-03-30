namespace Browser
{
    partial class Login
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
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.PassphraseBox = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.pass_label = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(122, 88);
            this.UserNameBox.MaxLength = 20;
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(124, 20);
            this.UserNameBox.TabIndex = 0;
            // 
            // PassphraseBox
            // 
            this.PassphraseBox.Location = new System.Drawing.Point(122, 140);
            this.PassphraseBox.MaxLength = 20;
            this.PassphraseBox.Name = "PassphraseBox";
            this.PassphraseBox.PasswordChar = '*';
            this.PassphraseBox.Size = new System.Drawing.Size(124, 20);
            this.PassphraseBox.TabIndex = 1;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(40, 88);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(55, 13);
            this.name_label.TabIndex = 2;
            this.name_label.Text = "Username";
            // 
            // pass_label
            // 
            this.pass_label.AutoSize = true;
            this.pass_label.Location = new System.Drawing.Point(39, 140);
            this.pass_label.Name = "pass_label";
            this.pass_label.Size = new System.Drawing.Size(62, 13);
            this.pass_label.TabIndex = 3;
            this.pass_label.Text = "Passphrase";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(122, 200);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.pass_label);
            this.Controls.Add(this.name_label);
            this.Controls.Add(this.PassphraseBox);
            this.Controls.Add(this.UserNameBox);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.TextBox PassphraseBox;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label pass_label;
        private System.Windows.Forms.Button LoginButton;
    }
}