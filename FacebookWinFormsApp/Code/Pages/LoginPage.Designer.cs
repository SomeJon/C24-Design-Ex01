namespace FacebookClient.Pages
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
            this.loginButton = new FacebookClient.Buttons.PageSwitchButton();
            this.ButtonExit = new FacebookClient.Buttons.PageSwitchButton();
            this.textBoxWelcomeMsg = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.settingButton = new FacebookClient.Buttons.PageSwitchButton();
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
            this.facebooklogo.Location = new System.Drawing.Point(688, 221);
            this.facebooklogo.Name = "facebooklogo";
            this.facebooklogo.Size = new System.Drawing.Size(120, 98);
            this.facebooklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebooklogo.TabIndex = 60;
            this.facebooklogo.TabStop = false;
            this.facebooklogo.Click += new System.EventHandler(this.facebooklogo_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.loginButton.Location = new System.Drawing.Point(317, 221);
            this.loginButton.Name = "loginButton";
            this.loginButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.HomePage;
            this.loginButton.Size = new System.Drawing.Size(336, 98);
            this.loginButton.TabIndex = 65;
            this.loginButton.Text = "Login with Facebook";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.ButtonExit.Location = new System.Drawing.Point(317, 325);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Exit;
            this.ButtonExit.Size = new System.Drawing.Size(336, 55);
            this.ButtonExit.TabIndex = 67;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBoxWelcomeMsg
            // 
            this.textBoxWelcomeMsg.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxWelcomeMsg.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxWelcomeMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxWelcomeMsg.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBoxWelcomeMsg.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBoxWelcomeMsg.Location = new System.Drawing.Point(160, 66);
            this.textBoxWelcomeMsg.Multiline = true;
            this.textBoxWelcomeMsg.Name = "textBoxWelcomeMsg";
            this.textBoxWelcomeMsg.Size = new System.Drawing.Size(671, 97);
            this.textBoxWelcomeMsg.TabIndex = 68;
            this.textBoxWelcomeMsg.Text = "welcome to facebook 2.0";
            this.textBoxWelcomeMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox4.BackColor = System.Drawing.Color.DarkBlue;
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.textBox4.Location = new System.Drawing.Point(245, 152);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(322, 39);
            this.textBox4.TabIndex = 71;
            this.textBox4.Text = "press the facebook logo :)";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(660, 344);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 24);
            this.textBox2.TabIndex = 73;
            this.textBox2.Text = "might be emoji";
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(723, 506);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 24);
            this.textBox1.TabIndex = 74;
            this.textBox1.Text = "might be emoji";
            this.textBox1.Visible = false;
            // 
            // settingButton
            // 
            this.settingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.settingButton.Location = new System.Drawing.Point(884, 458);
            this.settingButton.Name = "settingButton";
            this.settingButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.LoginSetting;
            this.settingButton.Size = new System.Drawing.Size(120, 86);
            this.settingButton.TabIndex = 66;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = true;
            this.settingButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // LoginPage
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBoxWelcomeMsg);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.facebooklogo);
            this.Controls.Add(this.timePanel);
            this.Name = "LoginPage";
            this.Size = new System.Drawing.Size(1007, 547);
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
        private Buttons.PageSwitchButton loginButton;
        private Buttons.PageSwitchButton ButtonExit;
        private System.Windows.Forms.TextBox textBoxWelcomeMsg;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Buttons.PageSwitchButton settingButton;
    }
}
