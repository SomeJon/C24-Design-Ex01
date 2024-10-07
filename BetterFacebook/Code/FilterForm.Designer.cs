using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookClient.Code
{
    partial class FilterForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.m_Cancel = new System.Windows.Forms.Button();
            this.m_SortingHeaderLabel = new System.Windows.Forms.Label();
            this.m_FetchFilterHeaderLabel = new System.Windows.Forms.Label();
            this.m_SortList = new System.Windows.Forms.ListBox();
            this.filterDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_FromHeader = new System.Windows.Forms.Label();
            this.m_MinLikesLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_TextContainsLabel = new System.Windows.Forms.Label();
            this.m_TextContainsBox = new System.Windows.Forms.TextBox();
            this.m_MinDatePicker = new System.Windows.Forms.DateTimePicker();
            this.m_MaxDatePicker = new System.Windows.Forms.DateTimePicker();
            this.m_MaxDateLabel = new System.Windows.Forms.Label();
            this.m_MinDateLabel = new System.Windows.Forms.Label();
            this.m_ReverseOrderCheckBox = new System.Windows.Forms.CheckBox();
            this.m_MatchAllFiltersCheckBox = new System.Windows.Forms.CheckBox();
            this.availableUsersToSelectBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageSquarePictureBox = new System.Windows.Forms.PictureBox();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.m_FilterCheckedList = new System.Windows.Forms.CheckedListBox();
            this.m_Confirm = new FacebookPages.Code.Buttons.LoadInfoButton();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableUsersToSelectBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Cancel
            // 
            this.m_Cancel.Location = new System.Drawing.Point(571, 273);
            this.m_Cancel.Name = "m_Cancel";
            this.m_Cancel.Size = new System.Drawing.Size(105, 52);
            this.m_Cancel.TabIndex = 1;
            this.m_Cancel.Text = "Cancel";
            this.m_Cancel.UseVisualStyleBackColor = true;
            this.m_Cancel.Click += new System.EventHandler(this.m_Cancel_Click);
            // 
            // m_SortingHeaderLabel
            // 
            this.m_SortingHeaderLabel.AutoSize = true;
            this.m_SortingHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_SortingHeaderLabel.Location = new System.Drawing.Point(27, 18);
            this.m_SortingHeaderLabel.Name = "m_SortingHeaderLabel";
            this.m_SortingHeaderLabel.Size = new System.Drawing.Size(114, 25);
            this.m_SortingHeaderLabel.TabIndex = 2;
            this.m_SortingHeaderLabel.Text = "Sort Type";
            // 
            // m_FetchFilterHeaderLabel
            // 
            this.m_FetchFilterHeaderLabel.AutoSize = true;
            this.m_FetchFilterHeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FetchFilterHeaderLabel.Location = new System.Drawing.Point(270, 18);
            this.m_FetchFilterHeaderLabel.Name = "m_FetchFilterHeaderLabel";
            this.m_FetchFilterHeaderLabel.Size = new System.Drawing.Size(78, 25);
            this.m_FetchFilterHeaderLabel.TabIndex = 4;
            this.m_FetchFilterHeaderLabel.Text = "Filters";
            // 
            // m_SortList
            // 
            this.m_SortList.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filterDataBindingSource, "PostSortingMethod", true));
            this.m_SortList.FormattingEnabled = true;
            this.m_SortList.ItemHeight = 18;
            this.m_SortList.Items.AddRange(new object[] {
            "Post Date published Not Working",
            "Post Date Updated",
            "Post Writer",
            "Post Type",
            "Post Likes",
            "Post Comments"});
            this.m_SortList.Location = new System.Drawing.Point(30, 46);
            this.m_SortList.Name = "m_SortList";
            this.m_SortList.Size = new System.Drawing.Size(223, 94);
            this.m_SortList.TabIndex = 3;
            // 
            // filterDataBindingSource
            // 
            this.filterDataBindingSource.DataSource = typeof(FacebookWrapperEnhancements.Code.Collection.Filter.FilterData);
            // 
            // m_FromHeader
            // 
            this.m_FromHeader.AutoSize = true;
            this.m_FromHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FromHeader.Location = new System.Drawing.Point(534, 78);
            this.m_FromHeader.Name = "m_FromHeader";
            this.m_FromHeader.Size = new System.Drawing.Size(149, 25);
            this.m_FromHeader.TabIndex = 6;
            this.m_FromHeader.Text = "User Source:";
            // 
            // m_MinLikesLabel
            // 
            this.m_MinLikesLabel.AutoSize = true;
            this.m_MinLikesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MinLikesLabel.Location = new System.Drawing.Point(12, 273);
            this.m_MinLikesLabel.Name = "m_MinLikesLabel";
            this.m_MinLikesLabel.Size = new System.Drawing.Size(0, 25);
            this.m_MinLikesLabel.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 303);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(215, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 13;
            // 
            // m_TextContainsLabel
            // 
            this.m_TextContainsLabel.AutoSize = true;
            this.m_TextContainsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_TextContainsLabel.Location = new System.Drawing.Point(100, 289);
            this.m_TextContainsLabel.Name = "m_TextContainsLabel";
            this.m_TextContainsLabel.Size = new System.Drawing.Size(165, 25);
            this.m_TextContainsLabel.TabIndex = 16;
            this.m_TextContainsLabel.Text = "Text Contains:";
            // 
            // m_TextContainsBox
            // 
            this.m_TextContainsBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filterDataBindingSource, "TextContainsString", true));
            this.m_TextContainsBox.Location = new System.Drawing.Point(275, 290);
            this.m_TextContainsBox.Name = "m_TextContainsBox";
            this.m_TextContainsBox.Size = new System.Drawing.Size(150, 24);
            this.m_TextContainsBox.TabIndex = 17;
            // 
            // m_MinDatePicker
            // 
            this.m_MinDatePicker.CustomFormat = "dd/MM/yyyy";
            this.m_MinDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filterDataBindingSource, "MinDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy"));
            this.m_MinDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_MinDatePicker.Location = new System.Drawing.Point(275, 250);
            this.m_MinDatePicker.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.m_MinDatePicker.Name = "m_MinDatePicker";
            this.m_MinDatePicker.Size = new System.Drawing.Size(150, 24);
            this.m_MinDatePicker.TabIndex = 18;
            this.m_MinDatePicker.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // m_MaxDatePicker
            // 
            this.m_MaxDatePicker.CustomFormat = "dd/MM/yyyy";
            this.m_MaxDatePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.filterDataBindingSource, "MaxDate", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "dd/MM/yyyy"));
            this.m_MaxDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.m_MaxDatePicker.Location = new System.Drawing.Point(275, 210);
            this.m_MaxDatePicker.Name = "m_MaxDatePicker";
            this.m_MaxDatePicker.Size = new System.Drawing.Size(150, 24);
            this.m_MaxDatePicker.TabIndex = 19;
            // 
            // m_MaxDateLabel
            // 
            this.m_MaxDateLabel.AutoSize = true;
            this.m_MaxDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MaxDateLabel.Location = new System.Drawing.Point(92, 210);
            this.m_MaxDateLabel.Name = "m_MaxDateLabel";
            this.m_MaxDateLabel.Size = new System.Drawing.Size(173, 25);
            this.m_MaxDateLabel.TabIndex = 20;
            this.m_MaxDateLabel.Text = "Max Post Date:";
            // 
            // m_MinDateLabel
            // 
            this.m_MinDateLabel.AutoSize = true;
            this.m_MinDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MinDateLabel.Location = new System.Drawing.Point(98, 250);
            this.m_MinDateLabel.Name = "m_MinDateLabel";
            this.m_MinDateLabel.Size = new System.Drawing.Size(167, 25);
            this.m_MinDateLabel.TabIndex = 21;
            this.m_MinDateLabel.Text = "Min Post Date:";
            // 
            // m_ReverseOrderCheckBox
            // 
            this.m_ReverseOrderCheckBox.AutoSize = true;
            this.m_ReverseOrderCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.filterDataBindingSource, "ReverseOrder", true));
            this.m_ReverseOrderCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ReverseOrderCheckBox.Location = new System.Drawing.Point(30, 151);
            this.m_ReverseOrderCheckBox.Name = "m_ReverseOrderCheckBox";
            this.m_ReverseOrderCheckBox.Size = new System.Drawing.Size(134, 22);
            this.m_ReverseOrderCheckBox.TabIndex = 22;
            this.m_ReverseOrderCheckBox.Text = "Reverse order";
            this.m_ReverseOrderCheckBox.UseVisualStyleBackColor = true;
            // 
            // m_MatchAllFiltersCheckBox
            // 
            this.m_MatchAllFiltersCheckBox.AutoSize = true;
            this.m_MatchAllFiltersCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.filterDataBindingSource, "MatchAllFilters", true));
            this.m_MatchAllFiltersCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_MatchAllFiltersCheckBox.Location = new System.Drawing.Point(277, 151);
            this.m_MatchAllFiltersCheckBox.Name = "m_MatchAllFiltersCheckBox";
            this.m_MatchAllFiltersCheckBox.Size = new System.Drawing.Size(148, 22);
            this.m_MatchAllFiltersCheckBox.TabIndex = 23;
            this.m_MatchAllFiltersCheckBox.Text = "Match All Filters";
            this.m_MatchAllFiltersCheckBox.UseVisualStyleBackColor = true;
            // 
            // availableUsersToSelectBindingSource
            // 
            this.availableUsersToSelectBindingSource.DataMember = "AvailableUsersToSelect";
            this.availableUsersToSelectBindingSource.DataSource = this.filterDataBindingSource;
            // 
            // imageSquarePictureBox
            // 
            this.imageSquarePictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.availableUsersToSelectBindingSource, "ImageSquare", true));
            this.imageSquarePictureBox.Location = new System.Drawing.Point(758, 12);
            this.imageSquarePictureBox.Name = "imageSquarePictureBox";
            this.imageSquarePictureBox.Size = new System.Drawing.Size(69, 59);
            this.imageSquarePictureBox.TabIndex = 24;
            this.imageSquarePictureBox.TabStop = false;
            // 
            // nameComboBox
            // 
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filterDataBindingSource, "UserSource", true));
            this.nameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.filterDataBindingSource, "UserSource", true));
            this.nameComboBox.DataSource = this.availableUsersToSelectBindingSource;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(689, 78);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(138, 26);
            this.nameComboBox.TabIndex = 26;
            // 
            // m_FilterCheckedList
            // 
            this.m_FilterCheckedList.FormattingEnabled = true;
            this.m_FilterCheckedList.Location = new System.Drawing.Point(275, 46);
            this.m_FilterCheckedList.Name = "m_FilterCheckedList";
            this.m_FilterCheckedList.Size = new System.Drawing.Size(236, 99);
            this.m_FilterCheckedList.TabIndex = 5;
            this.m_FilterCheckedList.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.m_FilterCheckedList_ItemCheck);
            // 
            // m_Confirm
            // 
            this.m_Confirm.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.AppId;
            this.m_Confirm.Location = new System.Drawing.Point(689, 273);
            this.m_Confirm.Name = "m_Confirm";
            this.m_Confirm.ReceivedInfo = null;
            this.m_Confirm.Size = new System.Drawing.Size(105, 52);
            this.m_Confirm.TabIndex = 0;
            this.m_Confirm.Text = "Confirm";
            this.m_Confirm.UseVisualStyleBackColor = true;
            this.m_Confirm.Click += new System.EventHandler(this.m_Confirm_Click);
            // 
            // FilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(879, 435);
            this.Controls.Add(this.imageSquarePictureBox);
            this.Controls.Add(this.nameComboBox);
            this.Controls.Add(this.m_MatchAllFiltersCheckBox);
            this.Controls.Add(this.m_ReverseOrderCheckBox);
            this.Controls.Add(this.m_MinDateLabel);
            this.Controls.Add(this.m_MaxDateLabel);
            this.Controls.Add(this.m_MaxDatePicker);
            this.Controls.Add(this.m_MinDatePicker);
            this.Controls.Add(this.m_TextContainsBox);
            this.Controls.Add(this.m_TextContainsLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_MinLikesLabel);
            this.Controls.Add(this.m_FromHeader);
            this.Controls.Add(this.m_FilterCheckedList);
            this.Controls.Add(this.m_FetchFilterHeaderLabel);
            this.Controls.Add(this.m_SortList);
            this.Controls.Add(this.m_SortingHeaderLabel);
            this.Controls.Add(this.m_Cancel);
            this.Controls.Add(this.m_Confirm);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Filter";
            ((System.ComponentModel.ISupportInitialize)(this.filterDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.availableUsersToSelectBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageSquarePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LoadInfoButton m_Confirm;
        private System.Windows.Forms.Button m_Cancel;
        private System.Windows.Forms.Label m_SortingHeaderLabel;
        private System.Windows.Forms.Label m_FetchFilterHeaderLabel;
        private System.Windows.Forms.ListBox m_SortList;
        private System.Windows.Forms.Label m_FromHeader;
        private System.Windows.Forms.Label m_MinLikesLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_TextContainsLabel;
        private System.Windows.Forms.TextBox m_TextContainsBox;
        private System.Windows.Forms.DateTimePicker m_MinDatePicker;
        private System.Windows.Forms.DateTimePicker m_MaxDatePicker;
        private System.Windows.Forms.Label m_MaxDateLabel;
        private System.Windows.Forms.Label m_MinDateLabel;
        private System.Windows.Forms.CheckBox m_ReverseOrderCheckBox;
        private System.Windows.Forms.CheckBox m_MatchAllFiltersCheckBox;
        private System.Windows.Forms.CheckedListBox m_FilterCheckedList;
        private System.Windows.Forms.BindingSource filterDataBindingSource;
        private System.Windows.Forms.BindingSource availableUsersToSelectBindingSource;
        private System.Windows.Forms.PictureBox imageSquarePictureBox;
        private System.Windows.Forms.ComboBox nameComboBox;
    }
}