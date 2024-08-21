using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages
{
    public partial class AboutMePage : BasePage
    {
        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelWorkingPlace;
        private System.Windows.Forms.Label labelStatus;
        private Buttons.PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelAducation;
        private System.Windows.Forms.Label Residence;
        public AboutMePageData Data { private get; set; }

        public AboutMePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void InitializeComponent()
        {
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelWorkingPlace = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.Residence = new System.Windows.Forms.Label();
            this.buttonReturn = new FacebookPages.Buttons.PageSwitchButton();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelAducation = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelAboutMe.Location = new System.Drawing.Point(23, 91);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(120, 28);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelBirthDate.Location = new System.Drawing.Point(44, 172);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(79, 20);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth date";
            // 
            // labelWorkingPlace
            // 
            this.labelWorkingPlace.AutoSize = true;
            this.labelWorkingPlace.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkingPlace.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelWorkingPlace.Location = new System.Drawing.Point(335, 219);
            this.labelWorkingPlace.Name = "labelWorkingPlace";
            this.labelWorkingPlace.Size = new System.Drawing.Size(109, 20);
            this.labelWorkingPlace.TabIndex = 3;
            this.labelWorkingPlace.Text = "Working place";
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelStatus.Location = new System.Drawing.Point(70, 219);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(53, 20);
            this.labelStatus.TabIndex = 4;
            this.labelStatus.Text = "Status";
            // 
            // Residence
            // 
            this.Residence.AutoSize = true;
            this.Residence.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Residence.Location = new System.Drawing.Point(365, 265);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(79, 20);
            this.Residence.TabIndex = 5;
            this.Residence.Text = "Residence";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.HomePage;
            this.buttonReturn.Size = new System.Drawing.Size(80, 36);
            this.buttonReturn.TabIndex = 69;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // labelHometown
            // 
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHometown.Location = new System.Drawing.Point(36, 265);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(87, 20);
            this.labelHometown.TabIndex = 70;
            this.labelHometown.Text = "Hometown";
            // 
            // labelAducation
            // 
            this.labelAducation.AutoSize = true;
            this.labelAducation.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelAducation.Location = new System.Drawing.Point(363, 172);
            this.labelAducation.Name = "labelAducation";
            this.labelAducation.Size = new System.Drawing.Size(81, 20);
            this.labelAducation.TabIndex = 2;
            this.labelAducation.Text = "Aducation";
            // 
            // AboutMePage
            // 
            this.BackColor = System.Drawing.Color.DarkBlue;
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
            this.VisibleChanged += new System.EventHandler(this.AboutMePage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AboutMePage_VisibleChanged(object sender, EventArgs e)
        {
            if (Data != null)
            {
                labelBirthDate.Text = "Birth date: " + Data.Birthday;

            }
        }
    }
}
