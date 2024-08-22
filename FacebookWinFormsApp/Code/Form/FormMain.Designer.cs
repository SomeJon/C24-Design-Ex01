using FacebookPages.Pages;

namespace FacebookClient.Code
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
            this.loginPage1 = new FacebookPages.Pages.LoginPage();
            this.loginSettingTab = new System.Windows.Forms.TabPage();
            this.settingPage1 = new FacebookPages.Pages.LoginPage();
            this.homeTab = new System.Windows.Forms.TabPage();
            this.homePage1 = new FacebookPages.Pages.HomePage();
            this.aboutMeTab = new System.Windows.Forms.TabPage();
            this.aboutMePage1 = new FacebookPages.Pages.AboutMePage();
            this.freindstave = new System.Windows.Forms.TabPage();
            this.friendsPage1 = new FacebookPages.Pages.FriendsPage();
            this.photoTab = new System.Windows.Forms.TabPage();
            this.photosPage1 = new FacebookPages.Pages.PhotosPage();
            this.tabControl.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.loginSettingTab.SuspendLayout();
            this.homeTab.SuspendLayout();
            this.aboutMeTab.SuspendLayout();
            this.freindstave.SuspendLayout();
            this.photoTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.loginTab);
            this.tabControl.Controls.Add(this.loginSettingTab);
            this.tabControl.Controls.Add(this.homeTab);
            this.tabControl.Controls.Add(this.aboutMeTab);
            this.tabControl.Controls.Add(this.freindstave);
            this.tabControl.Controls.Add(this.photoTab);
            this.tabControl.Location = new System.Drawing.Point(3, 1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(845, 593);
            this.tabControl.TabIndex = 0;
            // 
            // loginTab
            // 
            this.loginTab.Controls.Add(this.loginPage1);
            this.loginTab.Location = new System.Drawing.Point(4, 25);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(837, 564);
            this.loginTab.TabIndex = 0;
            this.loginTab.Text = "Login Page";
            this.loginTab.UseVisualStyleBackColor = true;
            // 
            // loginPage1
            // 
            this.loginPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loginPage1.Location = new System.Drawing.Point(3, 3);
            this.loginPage1.Name = "loginPage1";
            this.loginPage1.PageTheme = null;
            this.loginPage1.Size = new System.Drawing.Size(831, 558);
            this.loginPage1.TabIndex = 0;
            this.loginPage1.RemeberLogin += new System.EventHandler<System.EventArgs>(this.loginPage1_RemeberLogin);
            this.loginPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.loginPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // loginSettingTab
            // 
            this.loginSettingTab.Controls.Add(this.settingPage1);
            this.loginSettingTab.Location = new System.Drawing.Point(4, 25);
            this.loginSettingTab.Name = "loginSettingTab";
            this.loginSettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginSettingTab.Size = new System.Drawing.Size(192, 71);
            this.loginSettingTab.TabIndex = 1;
            this.loginSettingTab.Text = "LoginSettingsPage";
            this.loginSettingTab.UseVisualStyleBackColor = true;
            // 
            // settingPage1
            // 
            this.settingPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingPage1.Location = new System.Drawing.Point(3, 3);
            this.settingPage1.Margin = new System.Windows.Forms.Padding(4);
            this.settingPage1.Name = "settingPage1";
            this.settingPage1.PageTheme = null;
            this.settingPage1.Size = new System.Drawing.Size(186, 65);
            this.settingPage1.TabIndex = 0;
            this.settingPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.settingPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // homeTab
            // 
            this.homeTab.Controls.Add(this.homePage1);
            this.homeTab.Location = new System.Drawing.Point(4, 25);
            this.homeTab.Name = "homeTab";
            this.homeTab.Padding = new System.Windows.Forms.Padding(3);
            this.homeTab.Size = new System.Drawing.Size(192, 71);
            this.homeTab.TabIndex = 2;
            this.homeTab.Text = "Home Page";
            this.homeTab.UseVisualStyleBackColor = true;
            // 
            // homePage1
            // 
            this.homePage1.Location = new System.Drawing.Point(0, 0);
            this.homePage1.Margin = new System.Windows.Forms.Padding(4);
            this.homePage1.Name = "homePage1";
            this.homePage1.PageTheme = null;
            this.homePage1.Size = new System.Drawing.Size(837, 567);
            this.homePage1.TabIndex = 0;
            this.homePage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.homePage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // aboutMeTab
            // 
            this.aboutMeTab.Controls.Add(this.aboutMePage1);
            this.aboutMeTab.Location = new System.Drawing.Point(4, 25);
            this.aboutMeTab.Name = "aboutMeTab";
            this.aboutMeTab.Padding = new System.Windows.Forms.Padding(3);
            this.aboutMeTab.Size = new System.Drawing.Size(192, 71);
            this.aboutMeTab.TabIndex = 3;
            this.aboutMeTab.Text = "About";
            this.aboutMeTab.UseVisualStyleBackColor = true;
            // 
            // aboutMePage1
            // 
            this.aboutMePage1.BackColor = System.Drawing.Color.DarkBlue;
            this.aboutMePage1.Location = new System.Drawing.Point(0, 0);
            this.aboutMePage1.Name = "aboutMePage1";
            this.aboutMePage1.PageTheme = null;
            this.aboutMePage1.Size = new System.Drawing.Size(837, 571);
            this.aboutMePage1.TabIndex = 0;
            this.aboutMePage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.aboutMePage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // freindstave
            // 
            this.freindstave.Controls.Add(this.friendsPage1);
            this.freindstave.Location = new System.Drawing.Point(4, 25);
            this.freindstave.Name = "freindstave";
            this.freindstave.Padding = new System.Windows.Forms.Padding(3);
            this.freindstave.Size = new System.Drawing.Size(192, 71);
            this.freindstave.TabIndex = 4;
            this.freindstave.Text = "Friends";
            this.freindstave.UseVisualStyleBackColor = true;
            // 
            // friendsPage1
            // 
            this.friendsPage1.BackColor = System.Drawing.Color.DarkBlue;
            this.friendsPage1.Location = new System.Drawing.Point(0, 0);
            this.friendsPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.friendsPage1.Name = "friendsPage1";
            this.friendsPage1.PageTheme = null;
            this.friendsPage1.Size = new System.Drawing.Size(837, 567);
            this.friendsPage1.TabIndex = 0;
            this.friendsPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.friendsPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // photoTab
            // 
            this.photoTab.Controls.Add(this.photosPage1);
            this.photoTab.Location = new System.Drawing.Point(4, 25);
            this.photoTab.Name = "photoTab";
            this.photoTab.Padding = new System.Windows.Forms.Padding(3);
            this.photoTab.Size = new System.Drawing.Size(192, 71);
            this.photoTab.TabIndex = 5;
            this.photoTab.Text = "Photos";
            this.photoTab.UseVisualStyleBackColor = true;
            // 
            // photosPage1
            // 
            this.photosPage1.BackColor = System.Drawing.Color.DarkBlue;
            this.photosPage1.Location = new System.Drawing.Point(0, 0);
            this.photosPage1.Margin = new System.Windows.Forms.Padding(2);
            this.photosPage1.Name = "photosPage1";
            this.photosPage1.PageTheme = null;
            this.photosPage1.Size = new System.Drawing.Size(835, 567);
            this.photosPage1.TabIndex = 0;
            this.photosPage1.RecivedInfo += new System.EventHandler(this.loadInfoButton_RecievedInfo);
            this.photosPage1.ChangePage += new System.EventHandler(this.switchPageButton_ChangePage);
            // 
            // FormMain
            // 
            this.ClientSize = new System.Drawing.Size(846, 593);
            this.Controls.Add(this.tabControl);
            this.Name = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.tabControl.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.loginSettingTab.ResumeLayout(false);
            this.homeTab.ResumeLayout(false);
            this.aboutMeTab.ResumeLayout(false);
            this.freindstave.ResumeLayout(false);
            this.photoTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage loginSettingTab;
        private LoginPage loginPage1;
        private FacebookPages.Pages.LoginPage settingPage1;

        #endregion

        private System.Windows.Forms.TabPage homeTab;
        private System.Windows.Forms.TabPage aboutMeTab;
        private System.Windows.Forms.TabPage freindstave;
        private System.Windows.Forms.TabPage photoTab;
        private HomePage homePage1;
        private FacebookPages.Pages.FriendsPage friendsPage1;
        private FacebookPages.Pages.AboutMePage aboutMePage1;
        private FacebookPages.Pages.PhotosPage photosPage1;
    }
}

