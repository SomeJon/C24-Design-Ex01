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
            this.panel1 = new System.Windows.Forms.Panel();
            this.logoutButton = new FacebookClient.Buttons.PageSwitchButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.useCase2 = new FacebookClient.Buttons.PageSwitchButton();
            this.frienedButton = new FacebookClient.Buttons.PageSwitchButton();
            this.useCase1 = new FacebookClient.Buttons.PageSwitchButton();
            this.aboutButton = new FacebookClient.Buttons.PageSwitchButton();
            this.pictureButton = new FacebookClient.Buttons.PageSwitchButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.logoutButton);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(845, 163);
            this.panel1.TabIndex = 28;
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.logoutButton.Location = new System.Drawing.Point(0, 1);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.logoutButton.Size = new System.Drawing.Size(96, 42);
            this.logoutButton.TabIndex = 67;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 190);
            this.panel2.TabIndex = 29;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox1.Location = new System.Drawing.Point(8, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 24);
            this.textBox1.TabIndex = 57;
            this.textBox1.Text = "profile pic";
            this.textBox1.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Location = new System.Drawing.Point(2, 362);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(249, 182);
            this.panel3.TabIndex = 58;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(6, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(236, 24);
            this.textBox2.TabIndex = 57;
            this.textBox2.Text = "most liked picture";
            this.textBox2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox3.BackColor = System.Drawing.SystemColors.Info;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox3.Location = new System.Drawing.Point(14, 3);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(236, 24);
            this.textBox3.TabIndex = 58;
            this.textBox3.Text = "All posts and refresh button";
            this.textBox3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Location = new System.Drawing.Point(254, 363);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(588, 182);
            this.panel4.TabIndex = 59;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(673, 203);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(164, 21);
            this.comboBox2.TabIndex = 61;
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(640, 167);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(197, 24);
            this.textBox4.TabIndex = 59;
            this.textBox4.Text = "Switch background";
            this.textBox4.Visible = false;
            // 
            // useCase2
            // 
            this.useCase2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase2.Location = new System.Drawing.Point(258, 276);
            this.useCase2.Name = "useCase2";
            this.useCase2.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.UseCase2Page;
            this.useCase2.Size = new System.Drawing.Size(177, 30);
            this.useCase2.TabIndex = 66;
            this.useCase2.Text = "Use Cae 2";
            this.useCase2.UseVisualStyleBackColor = true;
            this.useCase2.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // frienedButton
            // 
            this.frienedButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.frienedButton.Location = new System.Drawing.Point(258, 204);
            this.frienedButton.Name = "frienedButton";
            this.frienedButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.FriendPage;
            this.frienedButton.Size = new System.Drawing.Size(177, 30);
            this.frienedButton.TabIndex = 65;
            this.frienedButton.Text = "Number of friends";
            this.frienedButton.UseVisualStyleBackColor = true;
            this.frienedButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // useCase1
            // 
            this.useCase1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.useCase1.Location = new System.Drawing.Point(258, 240);
            this.useCase1.Name = "useCase1";
            this.useCase1.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.UseCase1Page;
            this.useCase1.Size = new System.Drawing.Size(177, 30);
            this.useCase1.TabIndex = 64;
            this.useCase1.Text = "Use Case 1";
            this.useCase1.UseVisualStyleBackColor = true;
            this.useCase1.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aboutButton.Location = new System.Drawing.Point(258, 168);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.AboutMePage;
            this.aboutButton.Size = new System.Drawing.Size(177, 30);
            this.aboutButton.TabIndex = 63;
            this.aboutButton.Text = "About ME";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pictureButton.Location = new System.Drawing.Point(441, 168);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.PicturePage;
            this.pictureButton.Size = new System.Drawing.Size(177, 30);
            this.pictureButton.TabIndex = 62;
            this.pictureButton.Text = "Pictures";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Controls.Add(this.useCase2);
            this.Controls.Add(this.frienedButton);
            this.Controls.Add(this.useCase1);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pictureButton);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "HomePage";
            this.Size = new System.Drawing.Size(844, 547);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox2;
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
    }
}
