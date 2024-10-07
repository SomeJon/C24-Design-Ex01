using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Factory.Interfaces;

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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label countryLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label birthdayLabel;
            System.Windows.Forms.Label fullNameLabel;
            System.Windows.Forms.Label genderLabel;
            System.Windows.Forms.Label emailLabel;
            this.labelAboutMe = new System.Windows.Forms.Label();
            this.m_PersonalInfoLabel = new System.Windows.Forms.Label();
            this.m_LocationLabel = new System.Windows.Forms.Label();
            this.m_BackButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.AboutInfoPanel = new System.Windows.Forms.Panel();
            this.emailLabel1 = new System.Windows.Forms.Label();
            this.aboutMePageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genderLabel1 = new System.Windows.Forms.Label();
            this.fullNameLabel1 = new System.Windows.Forms.Label();
            this.birthdayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.cityLabel1 = new System.Windows.Forms.Label();
            this.countryLabel1 = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            countryLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            birthdayLabel = new System.Windows.Forms.Label();
            fullNameLabel = new System.Windows.Forms.Label();
            genderLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.AboutInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutMePageDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cityLabel.Location = new System.Drawing.Point(439, 12);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(34, 15);
            cityLabel.TabIndex = 16;
            cityLabel.Text = "City:";
            // 
            // countryLabel
            // 
            countryLabel.AutoSize = true;
            countryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryLabel.Location = new System.Drawing.Point(414, 42);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new System.Drawing.Size(59, 15);
            countryLabel.TabIndex = 18;
            countryLabel.Text = "Country:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(386, 76);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(87, 15);
            nameLabel.TabIndex = 19;
            nameLabel.Text = "Home Town:";
            // 
            // birthdayLabel
            // 
            birthdayLabel.AutoSize = true;
            birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            birthdayLabel.Location = new System.Drawing.Point(19, 41);
            birthdayLabel.Name = "birthdayLabel";
            birthdayLabel.Size = new System.Drawing.Size(63, 15);
            birthdayLabel.TabIndex = 20;
            birthdayLabel.Text = "Birthday:";
            // 
            // fullNameLabel
            // 
            fullNameLabel.AutoSize = true;
            fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fullNameLabel.Location = new System.Drawing.Point(6, 12);
            fullNameLabel.Name = "fullNameLabel";
            fullNameLabel.Size = new System.Drawing.Size(77, 15);
            fullNameLabel.TabIndex = 21;
            fullNameLabel.Text = "Full Name:";
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            genderLabel.Location = new System.Drawing.Point(23, 80);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new System.Drawing.Size(58, 15);
            genderLabel.TabIndex = 22;
            genderLabel.Text = "Gender:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(33, 114);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(48, 15);
            emailLabel.TabIndex = 23;
            emailLabel.Text = "Email:";
            // 
            // labelAboutMe
            // 
            this.labelAboutMe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelAboutMe.AutoSize = true;
            this.labelAboutMe.Font = new System.Drawing.Font("Arial", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelAboutMe.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAboutMe.Location = new System.Drawing.Point(188, 17);
            this.labelAboutMe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAboutMe.Name = "labelAboutMe";
            this.labelAboutMe.Size = new System.Drawing.Size(245, 55);
            this.labelAboutMe.TabIndex = 0;
            this.labelAboutMe.Text = "About me";
            // 
            // m_PersonalInfoLabel
            // 
            this.m_PersonalInfoLabel.AutoSize = true;
            this.m_PersonalInfoLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PersonalInfoLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_PersonalInfoLabel.Location = new System.Drawing.Point(4, 119);
            this.m_PersonalInfoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_PersonalInfoLabel.Name = "m_PersonalInfoLabel";
            this.m_PersonalInfoLabel.Size = new System.Drawing.Size(230, 30);
            this.m_PersonalInfoLabel.TabIndex = 2;
            this.m_PersonalInfoLabel.Text = "Personal Information";
            // 
            // m_LocationLabel
            // 
            this.m_LocationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_LocationLabel.AutoSize = true;
            this.m_LocationLabel.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_LocationLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.m_LocationLabel.Location = new System.Drawing.Point(355, 119);
            this.m_LocationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LocationLabel.Name = "m_LocationLabel";
            this.m_LocationLabel.Size = new System.Drawing.Size(277, 30);
            this.m_LocationLabel.TabIndex = 72;
            this.m_LocationLabel.Text = "Location and Background";
            // 
            // m_BackButton
            // 
            this.m_BackButton.BackColor = System.Drawing.Color.DarkBlue;
            this.m_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_BackButton.ForeColor = System.Drawing.Color.White;
            this.m_BackButton.Location = new System.Drawing.Point(0, 0);
            this.m_BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_BackButton.Name = "m_BackButton";
            this.m_BackButton.NewPageOwner = null;
            this.m_BackButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.WallPage;
            this.m_BackButton.Size = new System.Drawing.Size(132, 39);
            this.m_BackButton.TabIndex = 81;
            this.m_BackButton.Text = "Return";
            this.m_BackButton.UseVisualStyleBackColor = false;
            this.m_BackButton.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // AboutInfoPanel
            // 
            this.AboutInfoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AboutInfoPanel.BackColor = System.Drawing.Color.LightCyan;
            this.AboutInfoPanel.Controls.Add(emailLabel);
            this.AboutInfoPanel.Controls.Add(this.emailLabel1);
            this.AboutInfoPanel.Controls.Add(genderLabel);
            this.AboutInfoPanel.Controls.Add(this.genderLabel1);
            this.AboutInfoPanel.Controls.Add(fullNameLabel);
            this.AboutInfoPanel.Controls.Add(this.fullNameLabel1);
            this.AboutInfoPanel.Controls.Add(birthdayLabel);
            this.AboutInfoPanel.Controls.Add(this.birthdayDateTimePicker);
            this.AboutInfoPanel.Controls.Add(nameLabel);
            this.AboutInfoPanel.Controls.Add(this.nameLabel1);
            this.AboutInfoPanel.Controls.Add(cityLabel);
            this.AboutInfoPanel.Controls.Add(this.cityLabel1);
            this.AboutInfoPanel.Controls.Add(countryLabel);
            this.AboutInfoPanel.Controls.Add(this.countryLabel1);
            this.AboutInfoPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutInfoPanel.Location = new System.Drawing.Point(11, 172);
            this.AboutInfoPanel.Name = "AboutInfoPanel";
            this.AboutInfoPanel.Size = new System.Drawing.Size(696, 169);
            this.AboutInfoPanel.TabIndex = 82;
            // 
            // emailLabel1
            // 
            this.emailLabel1.AutoSize = true;
            this.emailLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "Email", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[NotFound]"));
            this.emailLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel1.Location = new System.Drawing.Point(111, 114);
            this.emailLabel1.Name = "emailLabel1";
            this.emailLabel1.Size = new System.Drawing.Size(77, 15);
            this.emailLabel1.TabIndex = 24;
            this.emailLabel1.Text = "[NotFound]";
            // 
            // aboutMePageDataBindingSource
            // 
            this.aboutMePageDataBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.AboutMePageData);
            // 
            // genderLabel1
            // 
            this.genderLabel1.AutoSize = true;
            this.genderLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "Gender", true));
            this.genderLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLabel1.Location = new System.Drawing.Point(113, 81);
            this.genderLabel1.Name = "genderLabel1";
            this.genderLabel1.Size = new System.Drawing.Size(77, 15);
            this.genderLabel1.TabIndex = 23;
            this.genderLabel1.Text = "[NotFound]";
            // 
            // fullNameLabel1
            // 
            this.fullNameLabel1.AutoSize = true;
            this.fullNameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "FullName", true));
            this.fullNameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel1.Location = new System.Drawing.Point(115, 11);
            this.fullNameLabel1.Name = "fullNameLabel1";
            this.fullNameLabel1.Size = new System.Drawing.Size(47, 15);
            this.fullNameLabel1.TabIndex = 22;
            this.fullNameLabel1.Text = "label1";
            // 
            // birthdayDateTimePicker
            // 
            this.birthdayDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.birthdayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.aboutMePageDataBindingSource, "Birthday", true, System.Windows.Forms.DataSourceUpdateMode.Never, null, "d"));
            this.birthdayDateTimePicker.Enabled = false;
            this.birthdayDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.birthdayDateTimePicker.Location = new System.Drawing.Point(114, 39);
            this.birthdayDateTimePicker.Name = "birthdayDateTimePicker";
            this.birthdayDateTimePicker.Size = new System.Drawing.Size(148, 21);
            this.birthdayDateTimePicker.TabIndex = 21;
            // 
            // nameLabel1
            // 
            this.nameLabel1.AutoSize = true;
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "Hometown.Name", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[NotFound]"));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.Location = new System.Drawing.Point(502, 76);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(77, 15);
            this.nameLabel1.TabIndex = 20;
            this.nameLabel1.Text = "[NotFound]";
            // 
            // cityLabel1
            // 
            this.cityLabel1.AutoSize = true;
            this.cityLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "Location.Location.City", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[NotFound]"));
            this.cityLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityLabel1.Location = new System.Drawing.Point(503, 11);
            this.cityLabel1.Name = "cityLabel1";
            this.cityLabel1.Size = new System.Drawing.Size(77, 15);
            this.cityLabel1.TabIndex = 17;
            this.cityLabel1.Text = "[NotFound]";
            // 
            // countryLabel1
            // 
            this.countryLabel1.AutoSize = true;
            this.countryLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aboutMePageDataBindingSource, "Location.Location.Country", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "[NotFound]"));
            this.countryLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countryLabel1.Location = new System.Drawing.Point(502, 42);
            this.countryLabel1.Name = "countryLabel1";
            this.countryLabel1.Size = new System.Drawing.Size(77, 15);
            this.countryLabel1.TabIndex = 19;
            this.countryLabel1.Text = "[NotFound]";
            // 
            // AboutMePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.AboutInfoPanel);
            this.Controls.Add(this.m_BackButton);
            this.Controls.Add(this.m_LocationLabel);
            this.Controls.Add(this.m_PersonalInfoLabel);
            this.Controls.Add(this.labelAboutMe);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AboutMePage";
            this.Size = new System.Drawing.Size(723, 344);
            this.AboutInfoPanel.ResumeLayout(false);
            this.AboutInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aboutMePageDataBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAboutMe;
        private System.Windows.Forms.Label m_PersonalInfoLabel;
        private System.Windows.Forms.Label m_LocationLabel;
        private PageSwitchButton m_BackButton;
        private System.Windows.Forms.Panel AboutInfoPanel;
        private System.Windows.Forms.BindingSource aboutMePageDataBindingSource;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label cityLabel1;
        private System.Windows.Forms.Label countryLabel1;
        private System.Windows.Forms.DateTimePicker birthdayDateTimePicker;
        private System.Windows.Forms.Label emailLabel1;
        private System.Windows.Forms.Label genderLabel1;
        private System.Windows.Forms.Label fullNameLabel1;
    }
}
