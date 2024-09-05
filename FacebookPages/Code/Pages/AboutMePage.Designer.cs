using FacebookPages.Code.Buttons;

namespace FacebookPages.Code.Pages
{
    partial class AboutMePage
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
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.m_BirthDateLabel = new System.Windows.Forms.Label();
            this.m_GenderLabel = new System.Windows.Forms.Label();
            this.m_FullNameLabel = new System.Windows.Forms.Label();
            this.m_ResidenceLabel = new System.Windows.Forms.Label();
            this.m_HometownLabel = new System.Windows.Forms.Label();
            this.m_PersonalInfoLabel = new System.Windows.Forms.Label();
            this.m_EmailLabel = new System.Windows.Forms.Label();
            this.m_LocationLabel = new System.Windows.Forms.Label();
            this.m_CountryLabel = new System.Windows.Forms.Label();
            this.m_FillNameLabel = new System.Windows.Forms.Label();
            this.m_FillBirthDayLabel = new System.Windows.Forms.Label();
            this.m_FillGenderLabel = new System.Windows.Forms.Label();
            this.m_FillEmailLabel = new System.Windows.Forms.Label();
            this.m_FillCountryLabel = new System.Windows.Forms.Label();
            this.m_FillCityLabel = new System.Windows.Forms.Label();
            this.m_FillHometownLabel = new System.Windows.Forms.Label();
            this.m_BackButton = new FacebookPages.Buttons.PageSwitchButton();
            this.SuspendLayout();
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAboutMe.Location = new System.Drawing.Point(137, 14);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(245, 55);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            // 
            // m_BirthDateLabel
            // 
            this.m_BirthDateLabel.AutoSize = true;
            this.m_BirthDateLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_BirthDateLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_BirthDateLabel.Location = new System.Drawing.Point(14, 183);
            this.m_BirthDateLabel.Name = "m_BirthDateLabel";
            this.m_BirthDateLabel.Size = new System.Drawing.Size(83, 20);
            this.m_BirthDateLabel.TabIndex = 1;
            this.m_BirthDateLabel.Text = "Birth date:";
            this.m_BirthDateLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_GenderLabel
            // 
            this.m_GenderLabel.AutoSize = true;
            this.m_GenderLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_GenderLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_GenderLabel.Location = new System.Drawing.Point(32, 221);
            this.m_GenderLabel.Name = "m_GenderLabel";
            this.m_GenderLabel.Size = new System.Drawing.Size(65, 20);
            this.m_GenderLabel.TabIndex = 3;
            this.m_GenderLabel.Text = "Gender:";
            this.m_GenderLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_FullNameLabel
            // 
            this.m_FullNameLabel.AutoSize = true;
            this.m_FullNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FullNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FullNameLabel.Location = new System.Drawing.Point(16, 147);
            this.m_FullNameLabel.Name = "m_FullNameLabel";
            this.m_FullNameLabel.Size = new System.Drawing.Size(81, 20);
            this.m_FullNameLabel.TabIndex = 4;
            this.m_FullNameLabel.Text = "Full name:";
            this.m_FullNameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_ResidenceLabel
            // 
            this.m_ResidenceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ResidenceLabel.AutoSize = true;
            this.m_ResidenceLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ResidenceLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_ResidenceLabel.Location = new System.Drawing.Point(303, 183);
            this.m_ResidenceLabel.Name = "m_ResidenceLabel";
            this.m_ResidenceLabel.Size = new System.Drawing.Size(40, 20);
            this.m_ResidenceLabel.TabIndex = 5;
            this.m_ResidenceLabel.Text = "City:";
            // 
            // m_HometownLabel
            // 
            this.m_HometownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_HometownLabel.AutoSize = true;
            this.m_HometownLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_HometownLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_HometownLabel.Location = new System.Drawing.Point(252, 220);
            this.m_HometownLabel.Name = "m_HometownLabel";
            this.m_HometownLabel.Size = new System.Drawing.Size(91, 20);
            this.m_HometownLabel.TabIndex = 70;
            this.m_HometownLabel.Text = "Hometown:";
            // 
            // m_PersonalInfoLabel
            // 
            this.m_PersonalInfoLabel.AutoSize = true;
            this.m_PersonalInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PersonalInfoLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_PersonalInfoLabel.Location = new System.Drawing.Point(3, 97);
            this.m_PersonalInfoLabel.Name = "m_PersonalInfoLabel";
            this.m_PersonalInfoLabel.Size = new System.Drawing.Size(230, 30);
            this.m_PersonalInfoLabel.TabIndex = 2;
            this.m_PersonalInfoLabel.Text = "Personal Information";
            // 
            // m_EmailLabel
            // 
            this.m_EmailLabel.AutoSize = true;
            this.m_EmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_EmailLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_EmailLabel.Location = new System.Drawing.Point(46, 263);
            this.m_EmailLabel.Name = "m_EmailLabel";
            this.m_EmailLabel.Size = new System.Drawing.Size(51, 20);
            this.m_EmailLabel.TabIndex = 71;
            this.m_EmailLabel.Text = "Email:";
            // 
            // m_LocationLabel
            // 
            this.m_LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_LocationLabel.AutoSize = true;
            this.m_LocationLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LocationLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_LocationLabel.Location = new System.Drawing.Point(247, 97);
            this.m_LocationLabel.Name = "m_LocationLabel";
            this.m_LocationLabel.Size = new System.Drawing.Size(277, 30);
            this.m_LocationLabel.TabIndex = 72;
            this.m_LocationLabel.Text = "Location and Background";
            // 
            // m_CountryLabel
            // 
            this.m_CountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_CountryLabel.AutoSize = true;
            this.m_CountryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_CountryLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_CountryLabel.Location = new System.Drawing.Point(273, 147);
            this.m_CountryLabel.Name = "m_CountryLabel";
            this.m_CountryLabel.Size = new System.Drawing.Size(70, 20);
            this.m_CountryLabel.TabIndex = 73;
            this.m_CountryLabel.Text = "Country:";
            // 
            // m_FillNameLabel
            // 
            this.m_FillNameLabel.AutoSize = true;
            this.m_FillNameLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillNameLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillNameLabel.Location = new System.Drawing.Point(115, 147);
            this.m_FillNameLabel.Name = "m_FillNameLabel";
            this.m_FillNameLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillNameLabel.TabIndex = 74;
            this.m_FillNameLabel.Text = "Text";
            // 
            // m_FillBirthDayLabel
            // 
            this.m_FillBirthDayLabel.AutoSize = true;
            this.m_FillBirthDayLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillBirthDayLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillBirthDayLabel.Location = new System.Drawing.Point(115, 183);
            this.m_FillBirthDayLabel.Name = "m_FillBirthDayLabel";
            this.m_FillBirthDayLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillBirthDayLabel.TabIndex = 75;
            this.m_FillBirthDayLabel.Text = "Text";
            // 
            // m_FillGenderLabel
            // 
            this.m_FillGenderLabel.AutoSize = true;
            this.m_FillGenderLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillGenderLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillGenderLabel.Location = new System.Drawing.Point(115, 221);
            this.m_FillGenderLabel.Name = "m_FillGenderLabel";
            this.m_FillGenderLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillGenderLabel.TabIndex = 76;
            this.m_FillGenderLabel.Text = "Text";
            // 
            // m_FillEmailLabel
            // 
            this.m_FillEmailLabel.AutoSize = true;
            this.m_FillEmailLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillEmailLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillEmailLabel.Location = new System.Drawing.Point(115, 263);
            this.m_FillEmailLabel.Name = "m_FillEmailLabel";
            this.m_FillEmailLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillEmailLabel.TabIndex = 77;
            this.m_FillEmailLabel.Text = "Text";
            // 
            // m_FillCountryLabel
            // 
            this.m_FillCountryLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FillCountryLabel.AutoSize = true;
            this.m_FillCountryLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillCountryLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillCountryLabel.Location = new System.Drawing.Point(365, 147);
            this.m_FillCountryLabel.Name = "m_FillCountryLabel";
            this.m_FillCountryLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillCountryLabel.TabIndex = 78;
            this.m_FillCountryLabel.Text = "Text";
            // 
            // m_FillCityLabel
            // 
            this.m_FillCityLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FillCityLabel.AutoSize = true;
            this.m_FillCityLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillCityLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillCityLabel.Location = new System.Drawing.Point(365, 183);
            this.m_FillCityLabel.Name = "m_FillCityLabel";
            this.m_FillCityLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillCityLabel.TabIndex = 79;
            this.m_FillCityLabel.Text = "Text";
            // 
            // m_FillHometownLabel
            // 
            this.m_FillHometownLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_FillHometownLabel.AutoSize = true;
            this.m_FillHometownLabel.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold);
            this.m_FillHometownLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_FillHometownLabel.Location = new System.Drawing.Point(365, 221);
            this.m_FillHometownLabel.Name = "m_FillHometownLabel";
            this.m_FillHometownLabel.Size = new System.Drawing.Size(39, 20);
            this.m_FillHometownLabel.TabIndex = 80;
            this.m_FillHometownLabel.Text = "Text";
            // 
            // m_BackButton
            // 
            this.m_BackButton.BackColor = System.Drawing.Color.DarkBlue;
            this.m_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_BackButton.ForeColor = System.Drawing.Color.White;
            this.m_BackButton.Location = new System.Drawing.Point(0, 0);
            this.m_BackButton.Name = "m_BackButton";
            this.m_BackButton.PageChoice = ePageChoice.WallPage;
            this.m_BackButton.Size = new System.Drawing.Size(99, 32);
            this.m_BackButton.TabIndex = 81;
            this.m_BackButton.Text = "Return";
            this.m_BackButton.UseVisualStyleBackColor = false;
            this.m_BackButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // AboutMePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.m_BackButton);
            this.Controls.Add(this.m_FillHometownLabel);
            this.Controls.Add(this.m_FillCityLabel);
            this.Controls.Add(this.m_FillCountryLabel);
            this.Controls.Add(this.m_FillEmailLabel);
            this.Controls.Add(this.m_FillGenderLabel);
            this.Controls.Add(this.m_FillBirthDayLabel);
            this.Controls.Add(this.m_FillNameLabel);
            this.Controls.Add(this.m_CountryLabel);
            this.Controls.Add(this.m_LocationLabel);
            this.Controls.Add(this.m_EmailLabel);
            this.Controls.Add(this.m_HometownLabel);
            this.Controls.Add(this.m_ResidenceLabel);
            this.Controls.Add(this.m_FullNameLabel);
            this.Controls.Add(this.m_GenderLabel);
            this.Controls.Add(this.m_PersonalInfoLabel);
            this.Controls.Add(this.m_BirthDateLabel);
            this.Controls.Add(this.labelAboutMe);
            this.Name = "AboutMePage";
            this.Size = new System.Drawing.Size(534, 310);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label m_BirthDateLabel;
        private System.Windows.Forms.Label m_GenderLabel;
        private System.Windows.Forms.Label m_FullNameLabel;
        private System.Windows.Forms.Label m_HometownLabel;
        private System.Windows.Forms.Label m_PersonalInfoLabel;
        private System.Windows.Forms.Label m_EmailLabel;
        private System.Windows.Forms.Label m_LocationLabel;
        private System.Windows.Forms.Label m_CountryLabel;
        private System.Windows.Forms.Label m_FillNameLabel;
        private System.Windows.Forms.Label m_FillBirthDayLabel;
        private System.Windows.Forms.Label m_FillGenderLabel;
        private System.Windows.Forms.Label m_FillEmailLabel;
        private System.Windows.Forms.Label m_FillCountryLabel;
        private System.Windows.Forms.Label m_FillCityLabel;
        private System.Windows.Forms.Label m_FillHometownLabel;
        private System.Windows.Forms.Label m_ResidenceLabel;
        private FacebookPages.Buttons.PageSwitchButton m_BackButton;
    }
}
