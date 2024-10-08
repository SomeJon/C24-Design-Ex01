using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Buttons
{
    partial class PostViewButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostViewButton));
            this.m_MorePostsButton = new System.Windows.Forms.Button();
            this.m_NumOfPostsInfo = new System.Windows.Forms.TextBox();
            this.m_PostImage = new System.Windows.Forms.PictureBox();
            this.feedListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wallPageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_FromLabel = new System.Windows.Forms.Label();
            this.m_ReactionNumLabel = new System.Windows.Forms.Label();
            this.m_CommentsNumLabel = new System.Windows.Forms.Label();
            this.m_FillComments = new System.Windows.Forms.Label();
            this.m_FillReactions = new System.Windows.Forms.Label();
            this.m_FillName = new System.Windows.Forms.Label();
            this.m_PostTypeChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.ePostConnectionOptionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_LoadAllButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_SwitchToAnalytics = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.m_FilterButton = new FacebookPages.Code.Buttons.LoadInfoButton();
            this.m_PostsList = new FacebookPages.Code.Buttons.LoadInfoListBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePostConnectionOptionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_MorePostsButton
            // 
            this.m_MorePostsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_MorePostsButton.Location = new System.Drawing.Point(530, 80);
            this.m_MorePostsButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_MorePostsButton.Name = "m_MorePostsButton";
            this.m_MorePostsButton.Size = new System.Drawing.Size(136, 31);
            this.m_MorePostsButton.TabIndex = 1;
            this.m_MorePostsButton.Text = "More posts";
            this.m_MorePostsButton.UseVisualStyleBackColor = true;
            this.m_MorePostsButton.Click += new System.EventHandler(this.m_MorePostsButton_Click);
            // 
            // m_NumOfPostsInfo
            // 
            this.m_NumOfPostsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_NumOfPostsInfo.Location = new System.Drawing.Point(7, 118);
            this.m_NumOfPostsInfo.Margin = new System.Windows.Forms.Padding(4);
            this.m_NumOfPostsInfo.Name = "m_NumOfPostsInfo";
            this.m_NumOfPostsInfo.ReadOnly = true;
            this.m_NumOfPostsInfo.Size = new System.Drawing.Size(149, 22);
            this.m_NumOfPostsInfo.TabIndex = 3;
            this.m_NumOfPostsInfo.Text = "Waiting for posts";
            // 
            // m_PostImage
            // 
            this.m_PostImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostImage.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.feedListBindingSource, "ImageUrl", true, System.Windows.Forms.DataSourceUpdateMode.Never));
            this.m_PostImage.Image = ((System.Drawing.Image)(resources.GetObject("m_PostImage.Image")));
            this.m_PostImage.Location = new System.Drawing.Point(787, 0);
            this.m_PostImage.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostImage.Name = "m_PostImage";
            this.m_PostImage.Size = new System.Drawing.Size(153, 96);
            this.m_PostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PostImage.TabIndex = 6;
            this.m_PostImage.TabStop = false;
            // 
            // feedListBindingSource
            // 
            this.feedListBindingSource.DataMember = "FeedList";
            this.feedListBindingSource.DataSource = this.wallPageDataBindingSource;
            this.feedListBindingSource.ListChanged += new System.ComponentModel.ListChangedEventHandler(this.feedListBindingSource_ListChanged);
            // 
            // wallPageDataBindingSource
            // 
            this.wallPageDataBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.WallPageData);
            // 
            // m_FromLabel
            // 
            this.m_FromLabel.AutoSize = true;
            this.m_FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FromLabel.ForeColor = System.Drawing.Color.Ivory;
            this.m_FromLabel.Location = new System.Drawing.Point(595, 0);
            this.m_FromLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FromLabel.Name = "m_FromLabel";
            this.m_FromLabel.Size = new System.Drawing.Size(44, 15);
            this.m_FromLabel.TabIndex = 9;
            this.m_FromLabel.Text = "From:";
            // 
            // m_ReactionNumLabel
            // 
            this.m_ReactionNumLabel.AutoSize = true;
            this.m_ReactionNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ReactionNumLabel.ForeColor = System.Drawing.Color.Ivory;
            this.m_ReactionNumLabel.Location = new System.Drawing.Point(563, 18);
            this.m_ReactionNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_ReactionNumLabel.Name = "m_ReactionNumLabel";
            this.m_ReactionNumLabel.Size = new System.Drawing.Size(75, 15);
            this.m_ReactionNumLabel.TabIndex = 10;
            this.m_ReactionNumLabel.Text = "Reactions:";
            // 
            // m_CommentsNumLabel
            // 
            this.m_CommentsNumLabel.AutoSize = true;
            this.m_CommentsNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_CommentsNumLabel.ForeColor = System.Drawing.Color.Ivory;
            this.m_CommentsNumLabel.Location = new System.Drawing.Point(559, 37);
            this.m_CommentsNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_CommentsNumLabel.Name = "m_CommentsNumLabel";
            this.m_CommentsNumLabel.Size = new System.Drawing.Size(79, 15);
            this.m_CommentsNumLabel.TabIndex = 11;
            this.m_CommentsNumLabel.Text = "Comments:";
            // 
            // m_FillComments
            // 
            this.m_FillComments.AutoSize = true;
            this.m_FillComments.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedListBindingSource, "NumOfComments", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "{No Data}"));
            this.m_FillComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillComments.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillComments.Location = new System.Drawing.Point(651, 37);
            this.m_FillComments.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FillComments.Name = "m_FillComments";
            this.m_FillComments.Size = new System.Drawing.Size(83, 15);
            this.m_FillComments.TabIndex = 12;
            this.m_FillComments.Text = "FillComments";
            // 
            // m_FillReactions
            // 
            this.m_FillReactions.AutoSize = true;
            this.m_FillReactions.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedListBindingSource, "NumOfLikes", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "{No Data}"));
            this.m_FillReactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillReactions.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillReactions.Location = new System.Drawing.Point(651, 18);
            this.m_FillReactions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FillReactions.Name = "m_FillReactions";
            this.m_FillReactions.Size = new System.Drawing.Size(78, 15);
            this.m_FillReactions.TabIndex = 13;
            this.m_FillReactions.Text = "FillReactions";
            // 
            // m_FillName
            // 
            this.m_FillName.AutoSize = true;
            this.m_FillName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feedListBindingSource, "From", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, "{No Data}"));
            this.m_FillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillName.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillName.Location = new System.Drawing.Point(651, 0);
            this.m_FillName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FillName.MaximumSize = new System.Drawing.Size(133, 0);
            this.m_FillName.Name = "m_FillName";
            this.m_FillName.Size = new System.Drawing.Size(57, 15);
            this.m_FillName.TabIndex = 14;
            this.m_FillName.Text = "FillName";
            // 
            // m_PostTypeChoiceComboBox
            // 
            this.m_PostTypeChoiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostTypeChoiceComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.wallPageDataBindingSource, "CurrentPageFeed.CurrentConnection", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.m_PostTypeChoiceComboBox.DataSource = this.ePostConnectionOptionsBindingSource;
            this.m_PostTypeChoiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.m_PostTypeChoiceComboBox.FormattingEnabled = true;
            this.m_PostTypeChoiceComboBox.Location = new System.Drawing.Point(281, 115);
            this.m_PostTypeChoiceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostTypeChoiceComboBox.Name = "m_PostTypeChoiceComboBox";
            this.m_PostTypeChoiceComboBox.Size = new System.Drawing.Size(143, 24);
            this.m_PostTypeChoiceComboBox.TabIndex = 16;
            this.m_PostTypeChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.m_PostTypeChoiceComboBox_SelectedIndexChanged);
            // 
            // ePostConnectionOptionsBindingSource
            // 
            this.ePostConnectionOptionsBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.UserPostFeed.ePostConnectionOptions);
            // 
            // m_LoadAllButton
            // 
            this.m_LoadAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_LoadAllButton.Location = new System.Drawing.Point(530, 115);
            this.m_LoadAllButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_LoadAllButton.Name = "m_LoadAllButton";
            this.m_LoadAllButton.Size = new System.Drawing.Size(136, 31);
            this.m_LoadAllButton.TabIndex = 19;
            this.m_LoadAllButton.Text = "Load All Matching";
            this.m_LoadAllButton.UseVisualStyleBackColor = true;
            this.m_LoadAllButton.Click += new System.EventHandler(this.m_LoadAllButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Change View:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Double click on post to open";
            // 
            // m_SwitchToAnalytics
            // 
            this.m_SwitchToAnalytics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_SwitchToAnalytics.Location = new System.Drawing.Point(670, 80);
            this.m_SwitchToAnalytics.Margin = new System.Windows.Forms.Padding(4);
            this.m_SwitchToAnalytics.Name = "m_SwitchToAnalytics";
            this.m_SwitchToAnalytics.NewPageOwner = null;
            this.m_SwitchToAnalytics.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.AnalyticPage;
            this.m_SwitchToAnalytics.Size = new System.Drawing.Size(111, 31);
            this.m_SwitchToAnalytics.TabIndex = 20;
            this.m_SwitchToAnalytics.Text = "Post Analytics";
            this.m_SwitchToAnalytics.UseVisualStyleBackColor = true;
            this.m_SwitchToAnalytics.Click += new System.EventHandler(this.m_SwitchToAnalytics_Click);
            // 
            // m_FilterButton
            // 
            this.m_FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_FilterButton.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.Filter;
            this.m_FilterButton.Location = new System.Drawing.Point(670, 115);
            this.m_FilterButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_FilterButton.Name = "m_FilterButton";
            this.m_FilterButton.ReceivedInfo = null;
            this.m_FilterButton.Size = new System.Drawing.Size(111, 31);
            this.m_FilterButton.TabIndex = 18;
            this.m_FilterButton.Text = "Filter Posts";
            this.m_FilterButton.UseVisualStyleBackColor = true;
            this.m_FilterButton.Click += new System.EventHandler(this.m_FilterButton_Click);
            // 
            // m_PostsList
            // 
            this.m_PostsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostsList.DataSource = this.feedListBindingSource;
            this.m_PostsList.DisplayMember = "CoverPicUrl";
            this.m_PostsList.FormattingEnabled = true;
            this.m_PostsList.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.Post;
            this.m_PostsList.ItemHeight = 16;
            this.m_PostsList.Location = new System.Drawing.Point(0, 0);
            this.m_PostsList.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostsList.Name = "m_PostsList";
            this.m_PostsList.ReceivedInfo = null;
            this.m_PostsList.Size = new System.Drawing.Size(525, 84);
            this.m_PostsList.TabIndex = 0;
            this.m_PostsList.ValueMember = "CoverPicUrl";
            this.m_PostsList.DoubleClick += new System.EventHandler(this.m_PostsList_DoubleClick);
            // 
            // PostViewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_SwitchToAnalytics);
            this.Controls.Add(this.m_LoadAllButton);
            this.Controls.Add(this.m_FilterButton);
            this.Controls.Add(this.m_PostTypeChoiceComboBox);
            this.Controls.Add(this.m_FillName);
            this.Controls.Add(this.m_FillReactions);
            this.Controls.Add(this.m_FillComments);
            this.Controls.Add(this.m_CommentsNumLabel);
            this.Controls.Add(this.m_ReactionNumLabel);
            this.Controls.Add(this.m_FromLabel);
            this.Controls.Add(this.m_PostImage);
            this.Controls.Add(this.m_NumOfPostsInfo);
            this.Controls.Add(this.m_MorePostsButton);
            this.Controls.Add(this.m_PostsList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostViewButton";
            this.Size = new System.Drawing.Size(940, 149);
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feedListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wallPageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ePostConnectionOptionsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_MorePostsButton;
        private System.Windows.Forms.TextBox m_NumOfPostsInfo;
        private System.Windows.Forms.PictureBox m_PostImage;
        protected LoadInfoListBox m_PostsList;
        private System.Windows.Forms.Label m_FromLabel;
        private System.Windows.Forms.Label m_ReactionNumLabel;
        private System.Windows.Forms.Label m_CommentsNumLabel;
        private System.Windows.Forms.Label m_FillComments;
        private System.Windows.Forms.Label m_FillReactions;
        private System.Windows.Forms.Label m_FillName;
        private System.Windows.Forms.ComboBox m_PostTypeChoiceComboBox;
        private LoadInfoButton m_FilterButton;
        private System.Windows.Forms.Button m_LoadAllButton;
        private PageSwitchButton m_SwitchToAnalytics;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource feedListBindingSource;
        private System.Windows.Forms.BindingSource wallPageDataBindingSource;
        private System.Windows.Forms.BindingSource ePostConnectionOptionsBindingSource;
    }
}
