namespace FacebookClient.Pages
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
            this.logoutButton = new FacebookClient.Buttons.PageSwitchButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.useCase2 = new FacebookClient.Buttons.PageSwitchButton();
            this.frienedButton = new FacebookClient.Buttons.PageSwitchButton();
            this.useCase1 = new FacebookClient.Buttons.PageSwitchButton();
            this.aboutButton = new FacebookClient.Buttons.PageSwitchButton();
            this.pictureButton = new FacebookClient.Buttons.PageSwitchButton();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.coverPicture = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.logoutButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
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
            this.textBox1.Location = new System.Drawing.Point(-1, 208);
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
            this.textBox3.Location = new System.Drawing.Point(-1, 412);
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
            this.panel4.BackColor = System.Drawing.Color.DarkBlue;
            this.panel4.Location = new System.Drawing.Point(4, 447);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1119, 224);
            this.panel4.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(879, 303);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 24);
            this.comboBox2.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(879, 276);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(217, 28);
            this.textBox4.TabIndex = 59;
            this.textBox4.Text = "select theme";
            this.textBox4.Visible = false;
            // 
            // useCase2
            // 
            this.useCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase2.Location = new System.Drawing.Point(344, 402);
            this.useCase2.Margin = new System.Windows.Forms.Padding(4);
            this.useCase2.Name = "useCase2";
            this.useCase2.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.UseCase2Page;
            this.useCase2.Size = new System.Drawing.Size(236, 37);
            this.useCase2.TabIndex = 66;
            this.useCase2.Text = "Use Cae 2";
            this.useCase2.UseVisualStyleBackColor = true;
            this.useCase2.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // frienedButton
            // 
            this.frienedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.frienedButton.Location = new System.Drawing.Point(344, 313);
            this.frienedButton.Margin = new System.Windows.Forms.Padding(4);
            this.frienedButton.Name = "frienedButton";
            this.frienedButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.FriendPage;
            this.frienedButton.Size = new System.Drawing.Size(236, 37);
            this.frienedButton.TabIndex = 65;
            this.frienedButton.Text = "Number of friends";
            this.frienedButton.UseVisualStyleBackColor = true;
            this.frienedButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // useCase1
            // 
            this.useCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase1.Location = new System.Drawing.Point(344, 357);
            this.useCase1.Margin = new System.Windows.Forms.Padding(4);
            this.useCase1.Name = "useCase1";
            this.useCase1.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.UseCase1Page;
            this.useCase1.Size = new System.Drawing.Size(236, 37);
            this.useCase1.TabIndex = 64;
            this.useCase1.Text = "Use Case 1";
            this.useCase1.UseVisualStyleBackColor = true;
            this.useCase1.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aboutButton.Location = new System.Drawing.Point(344, 267);
            this.aboutButton.Margin = new System.Windows.Forms.Padding(4);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.AboutMePage;
            this.aboutButton.Size = new System.Drawing.Size(236, 37);
            this.aboutButton.TabIndex = 63;
            this.aboutButton.Text = "About ME";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pictureButton.Location = new System.Drawing.Point(588, 267);
            this.pictureButton.Margin = new System.Windows.Forms.Padding(4);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.PicturePage;
            this.pictureButton.Size = new System.Drawing.Size(236, 37);
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
            this.textBoxFullName.Location = new System.Drawing.Point(343, 208);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(683, 52);
            this.textBoxFullName.TabIndex = 67;
            this.textBoxFullName.Text = "FULL NAME";
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // profilePicture
            // 
            this.profilePicture.Location = new System.Drawing.Point(-1, 207);
            this.profilePicture.Margin = new System.Windows.Forms.Padding(4);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(337, 233);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePicture.TabIndex = 68;
            this.profilePicture.TabStop = false;
            // 
            // coverPicture
            // 
            this.coverPicture.Location = new System.Drawing.Point(0, 0);
            this.coverPicture.Margin = new System.Windows.Forms.Padding(4);
            this.coverPicture.Name = "coverPicture";
            this.coverPicture.Size = new System.Drawing.Size(1125, 202);
            this.coverPicture.TabIndex = 69;
            this.coverPicture.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(140, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 28);
            this.textBox2.TabIndex = 72;
            this.textBox2.Text = "select back or emoji";
            this.textBox2.Visible = false;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.textBox3);
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
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel4);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(1125, 673);
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox4;
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
    }
}
