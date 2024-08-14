namespace FacebookClient.Code.Pages
{
    partial class FriendsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsPage));
            this.buttonReturn = new FacebookClient.Buttons.PageSwitchButton();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.Location = new System.Drawing.Point(5, 5);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(5);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.buttonReturn.Size = new System.Drawing.Size(171, 64);
            this.buttonReturn.TabIndex = 68;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(197, 3);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(60, 44);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 69;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Tag = "back";
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAboutMe.Location = new System.Drawing.Point(1, 101);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(186, 24);
            this.labelAboutMe.TabIndex = 70;
            this.labelAboutMe.Text = "number of friends:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 46);
            this.label1.TabIndex = 71;
            this.label1.Text = "my friends:";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(185, 54);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 28);
            this.textBox2.TabIndex = 75;
            this.textBox2.Text = "might be emoji";
            this.textBox2.Visible = false;
            // 
            // FriendsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelAboutMe);
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.buttonReturn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FriendsPage";
            this.Size = new System.Drawing.Size(788, 597);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Buttons.PageSwitchButton buttonReturn;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}
