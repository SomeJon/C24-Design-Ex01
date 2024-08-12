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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.MainPage = new System.Windows.Forms.TabControl();
            this.FrontPage = new System.Windows.Forms.TabPage();
            this.newLogin = new System.Windows.Forms.TabPage();
            this.loginSettingTab = new System.Windows.Forms.TabPage();
            this.HomePage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.buttonAboutme = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.facebooklogo = new System.Windows.Forms.PictureBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.loginPage = new FacebookClient.Pages.LoginPage();
            this.settingLoginPage = new FacebookClient.Pages.SettingPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.pictures = new System.Windows.Forms.TabPage();
            this.MainPage.SuspendLayout();
            this.FrontPage.SuspendLayout();
            this.newLogin.SuspendLayout();
            this.loginSettingTab.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(368, 176);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(281, 87);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login with Facebook";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // MainPage
            // 
            this.MainPage.Controls.Add(this.FrontPage);
            this.MainPage.Controls.Add(this.newLogin);
            this.MainPage.Controls.Add(this.loginSettingTab);
            this.MainPage.Controls.Add(this.HomePage);
            this.MainPage.Controls.Add(this.tabPage2);
            this.MainPage.Controls.Add(this.tabPage1);
            this.MainPage.Controls.Add(this.pictures);
            this.MainPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPage.Location = new System.Drawing.Point(0, 0);
            this.MainPage.Name = "MainPage";
            this.MainPage.SelectedIndex = 0;
            this.MainPage.Size = new System.Drawing.Size(1003, 686);
            this.MainPage.TabIndex = 54;
            // 
            // FrontPage
            // 
            this.FrontPage.BackColor = System.Drawing.Color.SteelBlue;
            this.FrontPage.Controls.Add(this.textBox9);
            this.FrontPage.Controls.Add(this.dateTimePicker1);
            this.FrontPage.Controls.Add(this.textBox8);
            this.FrontPage.Controls.Add(this.button4);
            this.FrontPage.Controls.Add(this.facebooklogo);
            this.FrontPage.Controls.Add(this.button3);
            this.FrontPage.Controls.Add(this.buttonLogin);
            this.FrontPage.Location = new System.Drawing.Point(4, 31);
            this.FrontPage.Name = "FrontPage";
            this.FrontPage.Padding = new System.Windows.Forms.Padding(3);
            this.FrontPage.Size = new System.Drawing.Size(995, 651);
            this.FrontPage.TabIndex = 0;
            this.FrontPage.Text = "Front Page";
            // 
            // newLogin
            // 
            this.newLogin.Controls.Add(this.loginPage);
            this.newLogin.Location = new System.Drawing.Point(4, 31);
            this.newLogin.Name = "newLogin";
            this.newLogin.Padding = new System.Windows.Forms.Padding(3);
            this.newLogin.Size = new System.Drawing.Size(995, 651);
            this.newLogin.TabIndex = 1;
            this.newLogin.Text = "New Login";
            this.newLogin.UseVisualStyleBackColor = true;
            // 
            // loginSettingTab
            // 
            this.loginSettingTab.Controls.Add(this.settingLoginPage);
            this.loginSettingTab.Location = new System.Drawing.Point(4, 31);
            this.loginSettingTab.Name = "loginSettingTab";
            this.loginSettingTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginSettingTab.Size = new System.Drawing.Size(995, 651);
            this.loginSettingTab.TabIndex = 2;
            this.loginSettingTab.Text = "Login Setting";
            this.loginSettingTab.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.HomePage.Location = new System.Drawing.Point(4, 31);
            this.HomePage.Name = "HomePage";
            this.HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.HomePage.Size = new System.Drawing.Size(995, 651);
            this.HomePage.TabIndex = 3;
            this.HomePage.Text = "About me Page";
            this.HomePage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.buttonAboutme);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(995, 651);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "Home page";
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Transparent;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(88, 38);
            this.button.TabIndex = 0;
            this.button.Text = "Logout";
            this.button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1001, 139);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(878, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 28);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Theme picture";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Location = new System.Drawing.Point(0, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 28);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Profile picture";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(0, 139);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(191, 138);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.textBox3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox3.Location = new System.Drawing.Point(188, 139);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 28);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Full name";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(188, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 30);
            this.button1.TabIndex = 8;
            this.button1.Text = "number of friends";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Info;
            this.textBox5.Location = new System.Drawing.Point(243, 308);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(249, 28);
            this.textBox5.TabIndex = 10;
            this.textBox5.Text = "show all my posts  - refresh";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.Info;
            this.textBox6.Location = new System.Drawing.Point(0, 560);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(182, 28);
            this.textBox6.TabIndex = 11;
            this.textBox6.Text = "my most likes picture";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(0, 408);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(204, 146);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // buttonAboutme
            // 
            this.buttonAboutme.BackColor = System.Drawing.Color.Transparent;
            this.buttonAboutme.Location = new System.Drawing.Point(188, 173);
            this.buttonAboutme.Name = "buttonAboutme";
            this.buttonAboutme.Size = new System.Drawing.Size(177, 30);
            this.buttonAboutme.TabIndex = 15;
            this.buttonAboutme.Text = "about me";
            this.buttonAboutme.UseVisualStyleBackColor = false;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Location = new System.Drawing.Point(831, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(168, 28);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "switch background";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(831, 164);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(168, 30);
            this.comboBox3.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(301, 39);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(409, 112);
            this.button3.TabIndex = 53;
            this.button3.Text = "Welcome to Facebook 2.0!!!";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // facebooklogo
            // 
            this.facebooklogo.BackColor = System.Drawing.Color.Transparent;
            this.facebooklogo.Image = ((System.Drawing.Image)(resources.GetObject("facebooklogo.Image")));
            this.facebooklogo.Location = new System.Drawing.Point(656, 176);
            this.facebooklogo.Name = "facebooklogo";
            this.facebooklogo.Size = new System.Drawing.Size(117, 87);
            this.facebooklogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.facebooklogo.TabIndex = 54;
            this.facebooklogo.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(368, 270);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(281, 39);
            this.button4.TabIndex = 55;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.SystemColors.Info;
            this.textBox8.Location = new System.Drawing.Point(-4, 147);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(361, 28);
            this.textBox8.TabIndex = 56;
            this.textBox8.Text = "press to throw facebook logos in the air";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(0, 3);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(295, 28);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.SystemColors.Info;
            this.textBox9.Location = new System.Drawing.Point(286, 315);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(246, 28);
            this.textBox9.TabIndex = 58;
            this.textBox9.Text = "new mini form to confirm exit";
            // 
            // loginPage
            // 
            this.loginPage.Location = new System.Drawing.Point(0, 0);
            this.loginPage.Margin = new System.Windows.Forms.Padding(6);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(1073, 658);
            this.loginPage.TabIndex = 0;
            this.loginPage.ChangePage += new System.EventHandler(this.loginPage1_SelectedChoice);
            // 
            // settingLoginPage
            // 
            this.settingLoginPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingLoginPage.Location = new System.Drawing.Point(3, 3);
            this.settingLoginPage.Margin = new System.Windows.Forms.Padding(4);
            this.settingLoginPage.Name = "settingLoginPage";
            this.settingLoginPage.Size = new System.Drawing.Size(989, 645);
            this.settingLoginPage.TabIndex = 0;
            this.settingLoginPage.RecivedInfo += new System.EventHandler(this.recivedInfo_PageControl);
            this.settingLoginPage.ChangePage += new System.EventHandler(this.changePage_PageControl);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(995, 651);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "Friends Page";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(188, 236);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(177, 30);
            this.button2.TabIndex = 19;
            this.button2.Text = "use case 1";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.Location = new System.Drawing.Point(188, 272);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(177, 30);
            this.button5.TabIndex = 20;
            this.button5.Text = "use case 2";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Location = new System.Drawing.Point(371, 173);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(177, 30);
            this.button6.TabIndex = 21;
            this.button6.Text = "pictures";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // pictures
            // 
            this.pictures.Location = new System.Drawing.Point(4, 31);
            this.pictures.Name = "pictures";
            this.pictures.Padding = new System.Windows.Forms.Padding(3);
            this.pictures.Size = new System.Drawing.Size(995, 651);
            this.pictures.TabIndex = 6;
            this.pictures.Text = "Pictures Page";
            this.pictures.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1003, 686);
            this.Controls.Add(this.MainPage);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.MainPage.ResumeLayout(false);
            this.FrontPage.ResumeLayout(false);
            this.FrontPage.PerformLayout();
            this.newLogin.ResumeLayout(false);
            this.loginSettingTab.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facebooklogo)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TabControl MainPage;
		private System.Windows.Forms.TabPage FrontPage;
		private System.Windows.Forms.TabPage newLogin;
        private System.Windows.Forms.TabPage loginSettingTab;
        private FacebookClient.Pages.LoginPage loginPage;
        private FacebookClient.Pages.SettingPage settingLoginPage;
        private System.Windows.Forms.TabPage HomePage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button buttonAboutme;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox facebooklogo;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TabPage pictures;
    }
}

