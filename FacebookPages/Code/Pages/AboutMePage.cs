using FacebookPages.Code.Pages.Data;
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
        private System.Windows.Forms.Label labelFullName;
        private Buttons.PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label labelHometown;
        private System.Windows.Forms.Label labelAducation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label fillNameLabel;
        private System.Windows.Forms.Label fillBirthDayLabel;
        private System.Windows.Forms.Label fillGenderLabel;
        private System.Windows.Forms.Label fillEmailLabel;
        private System.Windows.Forms.Label fillCountryLabel;
        private System.Windows.Forms.Label fillCityLabel;
        private System.Windows.Forms.Label fillHometownLabel;
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
            this.labelFullName = new System.Windows.Forms.Label();
            this.Residence = new System.Windows.Forms.Label();
            this.buttonReturn = new FacebookPages.Buttons.PageSwitchButton();
            this.labelHometown = new System.Windows.Forms.Label();
            this.labelAducation = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fillNameLabel = new System.Windows.Forms.Label();
            this.fillBirthDayLabel = new System.Windows.Forms.Label();
            this.fillGenderLabel = new System.Windows.Forms.Label();
            this.fillEmailLabel = new System.Windows.Forms.Label();
            this.fillCountryLabel = new System.Windows.Forms.Label();
            this.fillCityLabel = new System.Windows.Forms.Label();
            this.fillHometownLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAboutMe.Location = new System.Drawing.Point(153, 13);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(306, 68);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 183);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(103, 25);
            this.labelBirthDate.TabIndex = 1;
            this.labelBirthDate.Text = "Birth date:";
            this.labelBirthDate.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelWorkingPlace
            // 
            this.labelWorkingPlace.AutoSize = true;
            this.labelWorkingPlace.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkingPlace.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelWorkingPlace.Location = new System.Drawing.Point(29, 221);
            this.labelWorkingPlace.Name = "labelWorkingPlace";
            this.labelWorkingPlace.Size = new System.Drawing.Size(80, 25);
            this.labelWorkingPlace.TabIndex = 3;
            this.labelWorkingPlace.Text = "Gender:";
            this.labelWorkingPlace.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFullName.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelFullName.Location = new System.Drawing.Point(10, 147);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(99, 25);
            this.labelFullName.TabIndex = 4;
            this.labelFullName.Text = "Full name:";
            this.labelFullName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // Residence
            // 
            this.Residence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Residence.AutoSize = true;
            this.Residence.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Residence.ForeColor = System.Drawing.Color.DarkBlue;
            this.Residence.Location = new System.Drawing.Point(371, 183);
            this.Residence.Name = "Residence";
            this.Residence.Size = new System.Drawing.Size(50, 25);
            this.Residence.TabIndex = 5;
            this.Residence.Text = "City:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.BackColor = System.Drawing.Color.DarkBlue;
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.buttonReturn.ForeColor = System.Drawing.Color.White;
            this.buttonReturn.Location = new System.Drawing.Point(0, 0);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.PageChoice = FacebookPages.Buttons.PageSwitchButton.ePageChoice.HomePage;
            this.buttonReturn.Size = new System.Drawing.Size(80, 36);
            this.buttonReturn.TabIndex = 69;
            this.buttonReturn.Text = "return";
            this.buttonReturn.UseVisualStyleBackColor = false;
            this.buttonReturn.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // labelHometown
            // 
            this.labelHometown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHometown.AutoSize = true;
            this.labelHometown.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHometown.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelHometown.Location = new System.Drawing.Point(310, 221);
            this.labelHometown.Name = "labelHometown";
            this.labelHometown.Size = new System.Drawing.Size(111, 25);
            this.labelHometown.TabIndex = 70;
            this.labelHometown.Text = "Hometown:";
            // 
            // labelAducation
            // 
            this.labelAducation.AutoSize = true;
            this.labelAducation.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAducation.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAducation.Location = new System.Drawing.Point(3, 97);
            this.labelAducation.Name = "labelAducation";
            this.labelAducation.Size = new System.Drawing.Size(295, 38);
            this.labelAducation.TabIndex = 2;
            this.labelAducation.Text = "Personal Information";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(46, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 71;
            this.label1.Text = "Email:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(305, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(352, 38);
            this.label2.TabIndex = 72;
            this.label2.Text = "Location and Background";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkBlue;
            this.label3.Location = new System.Drawing.Point(335, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Country:";
            // 
            // fillNameLabel
            // 
            this.fillNameLabel.AutoSize = true;
            this.fillNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillNameLabel.Location = new System.Drawing.Point(115, 147);
            this.fillNameLabel.Name = "fillNameLabel";
            this.fillNameLabel.Size = new System.Drawing.Size(48, 25);
            this.fillNameLabel.TabIndex = 74;
            this.fillNameLabel.Text = "Text";
            // 
            // fillBirthDayLabel
            // 
            this.fillBirthDayLabel.AutoSize = true;
            this.fillBirthDayLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillBirthDayLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillBirthDayLabel.Location = new System.Drawing.Point(115, 183);
            this.fillBirthDayLabel.Name = "fillBirthDayLabel";
            this.fillBirthDayLabel.Size = new System.Drawing.Size(48, 25);
            this.fillBirthDayLabel.TabIndex = 75;
            this.fillBirthDayLabel.Text = "Text";
            // 
            // fillGenderLabel
            // 
            this.fillGenderLabel.AutoSize = true;
            this.fillGenderLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillGenderLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillGenderLabel.Location = new System.Drawing.Point(115, 221);
            this.fillGenderLabel.Name = "fillGenderLabel";
            this.fillGenderLabel.Size = new System.Drawing.Size(48, 25);
            this.fillGenderLabel.TabIndex = 76;
            this.fillGenderLabel.Text = "Text";
            // 
            // fillEmailLabel
            // 
            this.fillEmailLabel.AutoSize = true;
            this.fillEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillEmailLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillEmailLabel.Location = new System.Drawing.Point(115, 263);
            this.fillEmailLabel.Name = "fillEmailLabel";
            this.fillEmailLabel.Size = new System.Drawing.Size(48, 25);
            this.fillEmailLabel.TabIndex = 77;
            this.fillEmailLabel.Text = "Text";
            // 
            // fillCountryLabel
            // 
            this.fillCountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillCountryLabel.AutoSize = true;
            this.fillCountryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillCountryLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillCountryLabel.Location = new System.Drawing.Point(427, 147);
            this.fillCountryLabel.Name = "fillCountryLabel";
            this.fillCountryLabel.Size = new System.Drawing.Size(48, 25);
            this.fillCountryLabel.TabIndex = 78;
            this.fillCountryLabel.Text = "Text";
            // 
            // fillCityLabel
            // 
            this.fillCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillCityLabel.AutoSize = true;
            this.fillCityLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillCityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillCityLabel.Location = new System.Drawing.Point(427, 183);
            this.fillCityLabel.Name = "fillCityLabel";
            this.fillCityLabel.Size = new System.Drawing.Size(48, 25);
            this.fillCityLabel.TabIndex = 79;
            this.fillCityLabel.Text = "Text";
            // 
            // fillHometownLabel
            // 
            this.fillHometownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fillHometownLabel.AutoSize = true;
            this.fillHometownLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.fillHometownLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.fillHometownLabel.Location = new System.Drawing.Point(427, 221);
            this.fillHometownLabel.Name = "fillHometownLabel";
            this.fillHometownLabel.Size = new System.Drawing.Size(48, 25);
            this.fillHometownLabel.TabIndex = 80;
            this.fillHometownLabel.Text = "Text";
            // 
            // AboutMePage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.fillHometownLabel);
            this.Controls.Add(this.fillCityLabel);
            this.Controls.Add(this.fillCountryLabel);
            this.Controls.Add(this.fillEmailLabel);
            this.Controls.Add(this.fillGenderLabel);
            this.Controls.Add(this.fillBirthDayLabel);
            this.Controls.Add(this.fillNameLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelHometown);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.Residence);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.labelWorkingPlace);
            this.Controls.Add(this.labelAducation);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelAboutMe);
            this.Name = "AboutMePage";
            this.Size = new System.Drawing.Size(657, 310);
            this.VisibleChanged += new System.EventHandler(this.AboutMePage_VisibleChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void AboutMePage_VisibleChanged(object sender, EventArgs e)
        {
            if (Data != null)
            {
                fillBirthDayLabel.Text = Data.Birthday;
                fillCityLabel.Text = Data.Location?.Location.City;
                fillCountryLabel.Text = Data.Location.Location.Country;
                fillEmailLabel.Text = Data.Email;
                fillGenderLabel.Text = Data.Gender;
                fillNameLabel.Text = Data.Name;
                fillHometownLabel.Text = Data.Hometown?.Name;
            }
        }
    }
}
