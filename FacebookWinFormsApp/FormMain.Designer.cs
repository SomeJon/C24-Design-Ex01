namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.oldLogin = new System.Windows.Forms.TabPage();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.textBoxAppID = new System.Windows.Forms.TextBox();
            this.newLogin = new System.Windows.Forms.TabPage();
            this.loginPage = new FacebookClient.New_Buttons.LoginPage();
            this.loginSettingTab = new System.Windows.Forms.TabPage();
            this.settingLoginPage = new FacebookClient.New_Buttons.SettingPage();
            this.tabControl.SuspendLayout();
            this.oldLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.newLogin.SuspendLayout();
            this.loginSettingTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 17);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(268, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Enabled = false;
            this.buttonLogout.Location = new System.Drawing.Point(18, 57);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(268, 32);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 53;
            this.label1.Text = "App Id:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.oldLogin);
            this.tabControl.Controls.Add(this.newLogin);
            this.tabControl.Controls.Add(this.loginSettingTab);
            this.tabControl.Location = new System.Drawing.Point(-2, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1081, 689);
            this.tabControl.TabIndex = 54;
            // 
            // oldLogin
            // 
            this.oldLogin.Controls.Add(this.pictureBoxProfile);
            this.oldLogin.Controls.Add(this.textBoxAppID);
            this.oldLogin.Controls.Add(this.label1);
            this.oldLogin.Controls.Add(this.buttonLogout);
            this.oldLogin.Controls.Add(this.buttonLogin);
            this.oldLogin.Location = new System.Drawing.Point(4, 27);
            this.oldLogin.Name = "oldLogin";
            this.oldLogin.Padding = new System.Windows.Forms.Padding(3);
            this.oldLogin.Size = new System.Drawing.Size(1073, 658);
            this.oldLogin.TabIndex = 0;
            this.oldLogin.Text = "Old Login";
            this.oldLogin.UseVisualStyleBackColor = true;
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Location = new System.Drawing.Point(18, 96);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(79, 78);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // textBoxAppID
            // 
            this.textBoxAppID.Location = new System.Drawing.Point(317, 61);
            this.textBoxAppID.Name = "textBoxAppID";
            this.textBoxAppID.Size = new System.Drawing.Size(237, 24);
            this.textBoxAppID.TabIndex = 54;
            this.textBoxAppID.Text = "867142571975316";
            // 
            // newLogin
            // 
            this.newLogin.Controls.Add(this.loginPage);
            this.newLogin.Location = new System.Drawing.Point(4, 27);
            this.newLogin.Name = "newLogin";
            this.newLogin.Padding = new System.Windows.Forms.Padding(3);
            this.newLogin.Size = new System.Drawing.Size(1073, 658);
            this.newLogin.TabIndex = 1;
            this.newLogin.Text = "New Login";
            this.newLogin.UseVisualStyleBackColor = true;
            // 
            // loginPage
            // 
            this.loginPage.Location = new System.Drawing.Point(0, 0);
            this.loginPage.Margin = new System.Windows.Forms.Padding(6);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1073, 658);
            this.loginPage.TabIndex = 0;
            this.loginPage.SelectedChoice += new System.EventHandler(this.loginPage1_SelectedChoice);
            // 
            // loginSettingTab
            // 
            this.loginSettingTab.Controls.Add(this.settingLoginPage);
            this.loginSettingTab.Location = new System.Drawing.Point(4, 27);
            this.loginSettingTab.Name = "loginSettingTab";
            this.loginSettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginSettingTab.Size = new System.Drawing.Size(1073, 658);
            this.loginSettingTab.TabIndex = 2;
            this.loginSettingTab.Text = "Login Setting";
            this.loginSettingTab.UseVisualStyleBackColor = true;
            // 
            // settingLoginPage
            // 
            this.settingLoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingLoginPage.Location = new System.Drawing.Point(3, 3);
            this.settingLoginPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.settingLoginPage.Name = "settingLoginPage";
            this.settingLoginPage.Size = new System.Drawing.Size(1067, 652);
            this.settingLoginPage.TabIndex = 0;
            this.settingLoginPage.SettingChanged += new System.EventHandler(this.settingLoginPage_SettingChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 686);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.oldLogin.ResumeLayout(false);
            this.oldLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.newLogin.ResumeLayout(false);
            this.loginSettingTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage oldLogin;
		private System.Windows.Forms.TabPage newLogin;
        private System.Windows.Forms.TextBox textBoxAppID;
        private System.Windows.Forms.PictureBox pictureBoxProfile;
        private System.Windows.Forms.TabPage loginSettingTab;
        private FacebookClient.New_Buttons.LoginPage loginPage;
        private FacebookClient.New_Buttons.SettingPage settingLoginPage;
    }
}

