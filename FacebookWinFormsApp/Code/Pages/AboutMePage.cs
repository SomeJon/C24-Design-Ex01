using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookClient.Pages
{
    public class AboutMePage : BasePage
    {
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelAducation;
        private System.Windows.Forms.Label labelWorkingPlace;
        private System.Windows.Forms.Label labelStatus;
        private Buttons.PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBoxReturn;
        private System.Windows.Forms.Label Residence;

        public AboutMePage()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutMePage));
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelAducation = new System.Windows.Forms.Label();
            this.labelWorkingPlace = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.Residence = new System.Windows.Forms.Label();
            this.buttonReturn = new FacebookClient.Buttons.PageSwitchButton();
            this.labelHometown = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBoxReturn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAboutMe.Location = new System.Drawing.Point(67, 113);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(152, 34);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            this.labelAboutMe.Click += new System.EventHandler(this.labelAboutMe_Click);
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthDate.Location = new System.Drawing.Point(77, 172);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(98, 25);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth date";
            // 
            // labelAducation
            // 
            this.labelAducation.AutoSize = true;
            this.labelAducation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAducation.Location = new System.Drawing.Point(335, 172);
            this.labelAducation.Name = "labelAducation";
            this.labelAducation.Size = new System.Drawing.Size(100, 25);
            this.labelAducation.TabIndex = 2;
            this.labelAducation.Text = "Aducation";
            // 
            // labelWorkingPlace
            // 
            this.labelWorkingPlace.AutoSize = true;
            this.labelWorkingPlace.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkingPlace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWorkingPlace.Location = new System.Drawing.Point(335, 219);
            this.labelWorkingPlace.Name = "labelWorkingPlace";
            this.labelWorkingPlace.Size = new System.Drawing.Size(135, 25);
            this.labelWorkingPlace.TabIndex = 3;
            this.labelWorkingPlace.Text = "Working place";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Location = new System.Drawing.Point(77, 219);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(65, 25);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // Residence
            // 
            this.Residence.AutoSize = true;
            this.Residence.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Residence.Location = new System.Drawing.Point(346, 265);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(98, 25);
            this.Residence.TabIndex = 5;
            this.Residence.Text = "Residence";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = FacebookClient.Buttons.PageSwitchButton.ePageChoice.Logout;
            this.buttonReturn.Size = new System.Drawing.Size(128, 52);
            this.buttonReturn.TabIndex = 69;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHometown.Location = new System.Drawing.Point(77, 265);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(106, 25);
            this.labelHometown.TabIndex = 70;
            this.labelHometown.Text = "Hometown";
            // 
            // textBox4
            // 
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Info;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox4.Location = new System.Drawing.Point(305, 35);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(261, 28);
            this.textBox4.TabIndex = 71;
            this.textBox4.Text = "theme picture";
            this.textBox4.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.textBox2.Location = new System.Drawing.Point(125, 4);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(127, 28);
            this.textBox2.TabIndex = 74;
            this.textBox2.Text = "might be emoji";
            this.textBox2.Visible = false;
            // 
            // pictureBoxReturn
            // 
            this.pictureBoxReturn.Cursor = System.Windows.Forms.Cursors.No;
            this.pictureBoxReturn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxReturn.Image")));
            this.pictureBoxReturn.Location = new System.Drawing.Point(135, 35);
            this.pictureBoxReturn.Name = "pictureBoxReturn";
            this.pictureBoxReturn.Size = new System.Drawing.Size(60, 44);
            this.pictureBoxReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxReturn.TabIndex = 75;
            this.pictureBoxReturn.TabStop = false;
            this.pictureBoxReturn.Tag = "back";
            // 
            // AboutMePage
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.pictureBoxReturn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.Residence);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelWorkingPlace);
            this.Controls.Add(this.labelAducation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelAboutMe);
            this.Name = "AboutMePage";
            this.Size = new System.Drawing.Size(743, 368);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void labelAboutMe_Click(object sender, EventArgs e)
        {

        }
    }
}
