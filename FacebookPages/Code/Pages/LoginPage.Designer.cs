using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Pages
{
    partial class LoginPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.dateLabel = new System.Windows.Forms.Label();
            this.timePanel = new System.Windows.Forms.Panel();
            this.facebooklogo = new System.Windows.Forms.PictureBox();
            this.ButtonExit = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.settingButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.rememberLoginChackBox = new System.Windows.Forms.CheckBox();
            this.loginButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.Color.Transparent;
            this.dateLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dateLabel.Location = new System.Drawing.Point(0, 0);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(299, 21);
            this.dateLabel.TabIndex = 0;
            this.dateLabel.Text = "Showing the current date in dd/mm/yy";
            // 
            // timePanel
            // 
            this.timePanel.Controls.Add(this.dateLabel);
            this.timePanel.Location = new System.Drawing.Point(3, 3);
            this.timePanel.Name = "timePanel";
            this.timePanel.Size = new System.Drawing.Size(339, 26);
            this.timePanel.TabIndex = 1;
            // 
            // facebooklogo
            // 
            this.facebooklogo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.facebooklogo.BackColor = System.Drawing.Color.Transparent;
            this.facebooklogo.Image = ((System.Drawing.Image)(resources.GetObject("facebooklogo.Image")));
            this.facebooklogo.Location = new System.Drawing.Point(536, 221);
            this.facebooklogo.Name = "facebooklogo";
            this.facebooklogo.Size = new System.Drawing.Size(120, 98);
            this.facebooklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebooklogo.TabIndex = 60;
            this.facebooklogo.TabStop = false;
            this.facebooklogo.Click += new System.EventHandler(this.facebookLogo_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonExit.Location = new System.Drawing.Point(165, 335);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.NewPageOwner = null;
            this.ButtonExit.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.Exit;
            this.ButtonExit.Size = new System.Drawing.Size(336, 55);
            this.ButtonExit.TabIndex = 67;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.settingButton.Location = new System.Drawing.Point(580, 454);
            this.settingButton.Name = "settingButton";
            this.settingButton.NewPageOwner = null;
            this.settingButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.LoginSetting;
            this.settingButton.Size = new System.Drawing.Size(120, 86);
            this.settingButton.TabIndex = 66;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // rememberLoginChackBox
            // 
            this.rememberLoginChackBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rememberLoginChackBox.AutoSize = true;
            this.rememberLoginChackBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rememberLoginChackBox.Location = new System.Drawing.Point(180, 309);
            this.rememberLoginChackBox.Name = "rememberLoginChackBox";
            this.rememberLoginChackBox.Size = new System.Drawing.Size(106, 17);
            this.rememberLoginChackBox.TabIndex = 77;
            this.rememberLoginChackBox.Text = "Remember Login";
            this.rememberLoginChackBox.UseVisualStyleBackColor = true;
            this.rememberLoginChackBox.Click += new System.EventHandler(this.rememberLoginCheckBox_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.loginButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginButton.Location = new System.Drawing.Point(165, 214);
            this.loginButton.Name = "loginButton";
            this.loginButton.NewPageOwner = null;
            this.loginButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.HomePage;
            this.loginButton.Size = new System.Drawing.Size(336, 89);
            this.loginButton.TabIndex = 78;
            this.loginButton.Text = "Login with Facebook";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(432, 47);
            this.label1.TabIndex = 79;
            this.label1.Text = "welcome to facebook 2.0";
            // 
            // LoginPage
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.rememberLoginChackBox);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.facebooklogo);
            this.Controls.Add(this.timePanel);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(703, 543);
            this.Load += new System.EventHandler(this.LoginPage_Load);
            this.timePanel.ResumeLayout(false);
            this.timePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Panel timePanel;
        private System.Windows.Forms.PictureBox facebooklogo;
        private PageSwitchButton ButtonExit;
        private PageSwitchButton settingButton;
        private System.Windows.Forms.CheckBox rememberLoginChackBox;
        private PageSwitchButton loginButton;
        private System.Windows.Forms.Label label1;
    }
}
