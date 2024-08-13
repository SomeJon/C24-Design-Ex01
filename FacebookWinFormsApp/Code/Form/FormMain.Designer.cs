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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginSettingTab = new System.Windows.Forms.TabPage();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.aboutMeTab = new System.Windows.Forms.TabPage();
            this.freindstave = new System.Windows.Forms.TabPage();
            this.loginPage1 = new FacebookClient.Pages.LoginPage();
            this.settingPage1 = new FacebookClient.Pages.SettingPage();
            this.homePage1 = new FacebookClient.Pages.HomePage();
            this.aboutMePage1 = new FacebookClient.Pages.AboutMePage();
            this.friendsPage1 = new FacebookClient.Code.Pages.FriendsPage();
            this.tabControl.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.loginSettingTab.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.aboutMeTab.SuspendLayout();
            this.freindstave.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.loginTab);
            this.tabControl.Controls.Add(this.loginSettingTab);
            this.tabControl.Controls.Add(this.homeTab);
            this.tabControl.Controls.Add(this.aboutMeTab);
            this.tabControl.Controls.Add(this.freindstave);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(951, 624);
            this.tabControl.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginPage1);
            this.loginTab.Location = new System.Drawing.Point(4, 22);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(943, 598);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login Page";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginSettingTab
            // 
            this.loginSettingTab.Controls.Add(this.settingPage1);
            this.loginSettingTab.Location = new System.Drawing.Point(4, 22);
            this.loginSettingTab.Name = "loginSettingTab";
            this.loginSettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginSettingTab.Size = new System.Drawing.Size(943, 598);
            this.loginSettingTab.TabIndex = 1;
            this.loginSettingTab.Text = "LoginSettingsPage";
            this.loginSettingTab.UseVisualStyleBackColor = true;
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePage1);
            this.homeTab.Location = new System.Drawing.Point(4, 22);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(943, 598);
            this.homeTab.TabIndex = 2;
            this.homeTab.Text = "Home Page";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // aboutMeTab
            // 
            this.aboutMeTab.Controls.Add(this.aboutMePage1);
            this.aboutMeTab.Location = new System.Drawing.Point(4, 22);
            this.aboutMeTab.Name = "aboutMeTab";
            this.aboutMeTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutMeTab.Size = new System.Drawing.Size(943, 598);
            this.aboutMeTab.TabIndex = 3;
            this.aboutMeTab.Text = "About";
            this.aboutMeTab.UseVisualStyleBackColor = true;
            // 
            // freindstave
            // 
            this.freindstave.Controls.Add(this.friendsPage1);
            this.freindstave.Location = new System.Drawing.Point(4, 22);
            this.freindstave.Name = "freindstave";
            this.freindstave.Padding = new System.Windows.Forms.Padding(3);
            this.freindstave.Size = new System.Drawing.Size(943, 598);
            this.freindstave.TabIndex = 4;
            this.freindstave.Text = "Friends";
            this.freindstave.UseVisualStyleBackColor = true;
            // 
            // loginPage1
            // 
            this.loginPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage1.Location = new System.Drawing.Point(3, 3);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.Size = new System.Drawing.Size(937, 592);
            this.loginPage1.TabIndex = 0;
            this.loginPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.loginPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // settingPage1
            // 
            this.settingPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPage1.Location = new System.Drawing.Point(3, 3);
            this.settingPage1.Margin = new System.Windows.Forms.Padding(4);
            this.settingPage1.Name = "settingPage1";
            this.settingPage1.Size = new System.Drawing.Size(937, 592);
            this.settingPage1.TabIndex = 0;
            this.settingPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.settingPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // homePage1
            // 
            this.homePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.homePage1.Location = new System.Drawing.Point(3, 3);
            this.homePage1.Margin = new System.Windows.Forms.Padding(4);
            this.homePage1.Name = "homePage1";
            this.homePage1.Size = new System.Drawing.Size(937, 592);
            this.homePage1.TabIndex = 0;
            this.homePage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.homePage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // aboutMePage1
            // 
            this.aboutMePage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.aboutMePage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutMePage1.Location = new System.Drawing.Point(3, 3);
            this.aboutMePage1.Name = "aboutMePage1";
            this.aboutMePage1.Size = new System.Drawing.Size(937, 592);
            this.aboutMePage1.TabIndex = 0;
            // 
            // friendsPage1
            // 
            this.friendsPage1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.friendsPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.friendsPage1.Location = new System.Drawing.Point(3, 3);
            this.friendsPage1.Name = "friendsPage1";
            this.friendsPage1.Size = new System.Drawing.Size(937, 592);
            this.friendsPage1.TabIndex = 0;
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(951, 624);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.tabControl.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginSettingTab.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.aboutMeTab.ResumeLayout(false);
            this.freindstave.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage loginSettingTab;
        private FacebookClient.Pages.LoginPage loginPage1;
        private FacebookClient.Pages.SettingPage settingPage1;

        #endregion

        private System.Windows.Forms.TabPage homeTab;
        private FacebookClient.Pages.HomePage homePage1;
        private System.Windows.Forms.TabPage aboutMeTab;
        private System.Windows.Forms.TabPage freindstave;
        private FacebookClient.Pages.AboutMePage aboutMePage1;
        private FacebookClient.Code.Pages.FriendsPage friendsPage1;
    }
}

