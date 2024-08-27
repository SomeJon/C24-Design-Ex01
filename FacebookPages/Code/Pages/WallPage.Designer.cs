using FacebookPages.Code.Buttons;

namespace FacebookPages.Pages
{
    partial class WallPage
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
            this.frienedButton = new FacebookPages.Buttons.PageSwitchButton();
            this.aboutButton = new FacebookPages.Buttons.PageSwitchButton();
            this.pictureButton = new FacebookPages.Buttons.PageSwitchButton();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.coverPicture = new System.Windows.Forms.PictureBox();
            this.m_PostViewButton = new FacebookPages.Code.Buttons.PostViewButton();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.logoutButton.Location = new System.Drawing.Point(3, 3);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.PageChoice = ePageChoice.HomePage;
            this.logoutButton.Size = new System.Drawing.Size(96, 42);
            this.logoutButton.TabIndex = 67;
            this.logoutButton.Text = "Back";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(35, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 24);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "profile pic";
            this.textBox1.Visible = false;
            // 
            // frienedButton
            // 
            this.frienedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.frienedButton.Location = new System.Drawing.Point(420, 150);
            this.frienedButton.Name = "frienedButton";
            this.frienedButton.PageChoice = ePageChoice.FriendPage;
            this.frienedButton.Size = new System.Drawing.Size(133, 30);
            this.frienedButton.TabIndex = 65;
            this.frienedButton.Text = "Friends";
            this.frienedButton.UseVisualStyleBackColor = true;
            this.frienedButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aboutButton.Location = new System.Drawing.Point(238, 150);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.PageChoice = ePageChoice.AboutMePage;
            this.aboutButton.Size = new System.Drawing.Size(133, 30);
            this.aboutButton.TabIndex = 63;
            this.aboutButton.Text = "About ME";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pictureButton.Location = new System.Drawing.Point(239, 182);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.PageChoice = ePageChoice.PicturePage;
            this.pictureButton.Size = new System.Drawing.Size(132, 30);
            this.pictureButton.TabIndex = 62;
            this.pictureButton.Text = "Pictures";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFullName.Location = new System.Drawing.Point(236, 106);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(317, 44);
            this.textBoxFullName.TabIndex = 67;
            this.textBoxFullName.Text = "FULL NAME";
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.MediumBlue;
            this.profilePicture.Location = new System.Drawing.Point(0, 106);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(234, 182);
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
            this.coverPicture.Name = "coverPicture";
            this.coverPicture.Size = new System.Drawing.Size(660, 106);
            this.coverPicture.TabIndex = 69;
            this.coverPicture.TabStop = false;
            // 
            // m_PostViewButton
            // 
            this.m_PostViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostViewButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.m_PostViewButton.Location = new System.Drawing.Point(0, 289);
            this.m_PostViewButton.Name = "m_PostViewButton";
            this.m_PostViewButton.Size = new System.Drawing.Size(661, 101);
            this.m_PostViewButton.TabIndex = 73;
            // 
            // WallPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.m_PostViewButton);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.coverPicture);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.frienedButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pictureButton);
            this.Name = "WallPage";
            this.Size = new System.Drawing.Size(661, 390);
            this.Load += new System.EventHandler(this.WallPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private Buttons.PageSwitchButton pictureButton;
        private Buttons.PageSwitchButton aboutButton;
        private Buttons.PageSwitchButton frienedButton;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox coverPicture;
        private Code.Buttons.PostViewButton m_PostViewButton;
        protected Buttons.PageSwitchButton logoutButton;
    }
}
