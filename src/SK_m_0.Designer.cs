namespace Browser
{
    partial class SK_m_0
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
            this.URLBox = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TemperatureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionEvalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eulersMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chemicalBalancerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.WebSearch = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.molarMassToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLBox
            // 
            this.URLBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.URLBox.Location = new System.Drawing.Point(517, 27);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(176, 20);
            this.URLBox.TabIndex = 0;
            this.URLBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.URLBox_KeyPress);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(12, 53);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(681, 307);
            this.webBrowser1.TabIndex = 1;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.ToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(705, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.userInfoToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "File";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // userInfoToolStripMenuItem
            // 
            this.userInfoToolStripMenuItem.Name = "userInfoToolStripMenuItem";
            this.userInfoToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.userInfoToolStripMenuItem.Text = "User Info";
            this.userInfoToolStripMenuItem.Click += new System.EventHandler(this.userInfoToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.historyToolStripMenuItem.Text = "History";
            this.historyToolStripMenuItem.Click += new System.EventHandler(this.historyToolStripMenuItem_Click);
            // 
            // ToolsToolStripMenuItem
            // 
            this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TemperatureToolStripMenuItem,
            this.calculatorToolStripMenuItem,
            this.functionEvalToolStripMenuItem,
            this.eulersMethodToolStripMenuItem,
            this.chemicalBalancerToolStripMenuItem,
            this.molarMassToolStripMenuItem});
            this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
            this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.ToolsToolStripMenuItem.Text = "Tools";
            // 
            // TemperatureToolStripMenuItem
            // 
            this.TemperatureToolStripMenuItem.Name = "TemperatureToolStripMenuItem";
            this.TemperatureToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.TemperatureToolStripMenuItem.Text = "Temperature";
            this.TemperatureToolStripMenuItem.Click += new System.EventHandler(this.temperatureToolStripMenuItem_Click);
            // 
            // calculatorToolStripMenuItem
            // 
            this.calculatorToolStripMenuItem.Name = "calculatorToolStripMenuItem";
            this.calculatorToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.calculatorToolStripMenuItem.Text = "Calculator";
            this.calculatorToolStripMenuItem.Click += new System.EventHandler(this.calculatorToolStripMenuItem_Click);
            // 
            // functionEvalToolStripMenuItem
            // 
            this.functionEvalToolStripMenuItem.Name = "functionEvalToolStripMenuItem";
            this.functionEvalToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.functionEvalToolStripMenuItem.Text = "Function Eval";
            this.functionEvalToolStripMenuItem.Click += new System.EventHandler(this.functionEvalToolStripMenuItem_Click);
            // 
            // eulersMethodToolStripMenuItem
            // 
            this.eulersMethodToolStripMenuItem.Name = "eulersMethodToolStripMenuItem";
            this.eulersMethodToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.eulersMethodToolStripMenuItem.Text = "Euler\'s Method";
            this.eulersMethodToolStripMenuItem.Click += new System.EventHandler(this.eulersMethodToolStripMenuItem_Click);
            // 
            // chemicalBalancerToolStripMenuItem
            // 
            this.chemicalBalancerToolStripMenuItem.Name = "chemicalBalancerToolStripMenuItem";
            this.chemicalBalancerToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.chemicalBalancerToolStripMenuItem.Text = "Chemical Balancer";
            this.chemicalBalancerToolStripMenuItem.Click += new System.EventHandler(this.chemicalBalancerToolStripMenuItem_Click);
            // 
            // WebSearch
            // 
            this.WebSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WebSearch.Location = new System.Drawing.Point(436, 27);
            this.WebSearch.Name = "WebSearch";
            this.WebSearch.Size = new System.Drawing.Size(75, 23);
            this.WebSearch.TabIndex = 3;
            this.WebSearch.Text = "Search";
            this.WebSearch.UseVisualStyleBackColor = true;
            this.WebSearch.Click += new System.EventHandler(this.WebSearch_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 27);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(29, 23);
            this.buttonBack.TabIndex = 4;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(47, 27);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(29, 23);
            this.buttonForward.TabIndex = 5;
            this.buttonForward.Text = "->";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // molarMassToolStripMenuItem
            // 
            this.molarMassToolStripMenuItem.Name = "molarMassToolStripMenuItem";
            this.molarMassToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.molarMassToolStripMenuItem.Text = "Molar Mass";
            this.molarMassToolStripMenuItem.Click += new System.EventHandler(this.molarMassToolStripMenuItem_Click);
            // 
            // SK_m_0
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 364);
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.WebSearch);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SK_m_0";
            this.Text = "SK_m_0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLBox;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TemperatureToolStripMenuItem;
        private System.Windows.Forms.Button WebSearch;
        private System.Windows.Forms.ToolStripMenuItem calculatorToolStripMenuItem;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.ToolStripMenuItem functionEvalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eulersMethodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chemicalBalancerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem molarMassToolStripMenuItem;
    }
}

