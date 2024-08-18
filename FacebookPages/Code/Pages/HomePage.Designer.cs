namespace FacebookPages.Pages
{
    partial class HomePage
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
            this.logoutButton = new FacebookPages.Buttons.PageSwitchButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.useCase2 = new FacebookPages.Buttons.PageSwitchButton();
            this.frienedButton = new FacebookPages.Buttons.PageSwitchButton();
            this.useCase1 = new FacebookPages.Buttons.PageSwitchButton();
            this.aboutButton = new FacebookPages.Buttons.PageSwitchButton();
            this.pictureButton = new FacebookPages.Buttons.PageSwitchButton();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.coverPicture = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.m_SettingButton = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.logoutButton.Location = new System.Drawing.Point(4, 4);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.logoutButton.Size = new System.Drawing.Size(128, 52);
            this.logoutButton.TabIndex = 67;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(19, 173);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 28);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "profile pic";
            this.textBox1.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(3, 18);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(313, 28);
            this.textBox3.TabIndex = 58;
            this.textBox3.Text = "All posts and refresh button";
            this.textBox3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.SkyBlue;
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Location = new System.Drawing.Point(4, 359);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(820, 122);
            this.panel4.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(322, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Posts";
            // 
            // useCase2
            // 
            this.useCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase2.Location = new System.Drawing.Point(316, 307);
            this.useCase2.Margin = new System.Windows.Forms.Padding(4);
            this.useCase2.Name = "useCase2";
            this.useCase2.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.UseCase2Page;
            this.useCase2.Size = new System.Drawing.Size(177, 37);
            this.useCase2.TabIndex = 66;
            this.useCase2.Text = "Use Cae 2";
            this.useCase2.UseVisualStyleBackColor = true;
            this.useCase2.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // frienedButton
            // 
            this.frienedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.frienedButton.Location = new System.Drawing.Point(316, 225);
            this.frienedButton.Margin = new System.Windows.Forms.Padding(4);
            this.frienedButton.Name = "frienedButton";
            this.frienedButton.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.FriendPage;
            this.frienedButton.Size = new System.Drawing.Size(177, 37);
            this.frienedButton.TabIndex = 65;
            this.frienedButton.Text = "Friends";
            this.frienedButton.UseVisualStyleBackColor = true;
            this.frienedButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // useCase1
            // 
            this.useCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase1.Location = new System.Drawing.Point(316, 266);
            this.useCase1.Margin = new System.Windows.Forms.Padding(4);
            this.useCase1.Name = "useCase1";
            this.useCase1.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.UseCase1Page;
            this.useCase1.Size = new System.Drawing.Size(177, 37);
            this.useCase1.TabIndex = 64;
            this.useCase1.Text = "Use Case 1";
            this.useCase1.UseVisualStyleBackColor = true;
            this.useCase1.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aboutButton.Location = new System.Drawing.Point(317, 185);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.AboutMePage;
            this.aboutButton.Size = new System.Drawing.Size(177, 37);
            this.aboutButton.TabIndex = 63;
            this.aboutButton.Text = "About ME";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pictureButton.Location = new System.Drawing.Point(554, 185);
            this.pictureButton.Margin = new System.Windows.Forms.Padding(4);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.PicturePage;
            this.pictureButton.Size = new System.Drawing.Size(176, 37);
            this.pictureButton.TabIndex = 62;
            this.pictureButton.Text = "Pictures";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFullName.Location = new System.Drawing.Point(314, 131);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(421, 53);
            this.textBoxFullName.TabIndex = 67;
            this.textBoxFullName.Text = "FULL NAME";
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.MediumBlue;
            this.profilePicture.Location = new System.Drawing.Point(4, 134);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(308, 220);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 68;
            this.profilePicture.TabStop = false;
            // 
            // coverPicture
            // 
            this.coverPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coverPicture.BackColor = System.Drawing.Color.Navy;
            this.coverPicture.Location = new System.Drawing.Point(0, 0);
            this.coverPicture.Margin = new System.Windows.Forms.Padding(4);
            this.coverPicture.Name = "coverPicture";
            this.coverPicture.Size = new System.Drawing.Size(824, 130);
            this.coverPicture.TabIndex = 69;
            this.coverPicture.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(174, 5);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 28);
            this.textBox2.TabIndex = 72;
            this.textBox2.Text = "select back or emoji";
            this.textBox2.Visible = false;
            // 
            // m_SettingButton
            // 
            this.m_SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_SettingButton.Location = new System.Drawing.Point(769, 131);
            this.m_SettingButton.Name = "m_SettingButton";
            this.m_SettingButton.Size = new System.Drawing.Size(54, 49);
            this.m_SettingButton.TabIndex = 73;
            this.m_SettingButton.Text = "setting";
            this.m_SettingButton.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.m_SettingButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.coverPicture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.useCase2);
            this.Controls.Add(this.frienedButton);
            this.Controls.Add(this.useCase1);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(825, 480);
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private Buttons.PageSwitchButton pictureButton;
        private Buttons.PageSwitchButton aboutButton;
        private Buttons.PageSwitchButton useCase1;
        private Buttons.PageSwitchButton frienedButton;
        private Buttons.PageSwitchButton useCase2;
        private Buttons.PageSwitchButton logoutButton;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox coverPicture;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_SettingButton;
    }
}
