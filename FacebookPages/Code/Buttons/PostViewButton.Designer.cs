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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostViewButton));
            this.m_MorePostsButton = new System.Windows.Forms.Button();
            this.m_NumOfPostsInfo = new System.Windows.Forms.TextBox();
            this.m_PostImage = new System.Windows.Forms.PictureBox();
            this.m_InstructionLabel = new System.Windows.Forms.Label();
            this.m_FromLabel = new System.Windows.Forms.Label();
            this.m_ReactionNumLabel = new System.Windows.Forms.Label();
            this.m_CommentsNumLabel = new System.Windows.Forms.Label();
            this.m_FillComments = new System.Windows.Forms.Label();
            this.m_FillReactions = new System.Windows.Forms.Label();
            this.m_FillName = new System.Windows.Forms.Label();
            this.m_PostTypeChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.m_ChangeConnectionButton = new System.Windows.Forms.Button();
            this.m_FilterButton = new FacebookPages.Buttons.LoadInfoButton();
            this.m_PostsList = new FacebookPages.Code.Buttons.LoadInfoListBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // m_MorePostsButton
            // 
            this.m_MorePostsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_MorePostsButton.Location = new System.Drawing.Point(396, 75);
            this.m_MorePostsButton.Name = "m_MorePostsButton";
            this.m_MorePostsButton.Size = new System.Drawing.Size(102, 25);
            this.m_MorePostsButton.TabIndex = 1;
            this.m_MorePostsButton.Text = "More posts";
            this.m_MorePostsButton.UseVisualStyleBackColor = true;
            this.m_MorePostsButton.Click += new System.EventHandler(this.m_MorePostsButton_Click);
            // 
            // m_NumOfPostsInfo
            // 
            this.m_NumOfPostsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_NumOfPostsInfo.Location = new System.Drawing.Point(2, 69);
            this.m_NumOfPostsInfo.Name = "m_NumOfPostsInfo";
            this.m_NumOfPostsInfo.ReadOnly = true;
            this.m_NumOfPostsInfo.Size = new System.Drawing.Size(113, 20);
            this.m_NumOfPostsInfo.TabIndex = 3;
            this.m_NumOfPostsInfo.Text = "Waiting for posts";
            // 
            // m_PostImage
            // 
            this.m_PostImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostImage.Image = ((System.Drawing.Image)(resources.GetObject("m_PostImage.Image")));
            this.m_PostImage.Location = new System.Drawing.Point(595, 0);
            this.m_PostImage.Name = "m_PostImage";
            this.m_PostImage.Size = new System.Drawing.Size(90, 71);
            this.m_PostImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PostImage.TabIndex = 6;
            this.m_PostImage.TabStop = false;
            // 
            // m_InstructionLabel
            // 
            this.m_InstructionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_InstructionLabel.AutoSize = true;
            this.m_InstructionLabel.Location = new System.Drawing.Point(3, 88);
            this.m_InstructionLabel.Name = "m_InstructionLabel";
            this.m_InstructionLabel.Size = new System.Drawing.Size(163, 13);
            this.m_InstructionLabel.TabIndex = 7;
            this.m_InstructionLabel.Text = "(Doublt click on a post to open it)";
            // 
            // m_FromLabel
            // 
            this.m_FromLabel.AutoSize = true;
            this.m_FromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FromLabel.ForeColor = System.Drawing.Color.Ivory;
            this.m_FromLabel.Location = new System.Drawing.Point(428, 4);
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
            this.m_ReactionNumLabel.Location = new System.Drawing.Point(397, 19);
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
            this.m_CommentsNumLabel.Location = new System.Drawing.Point(393, 34);
            this.m_CommentsNumLabel.Name = "m_CommentsNumLabel";
            this.m_CommentsNumLabel.Size = new System.Drawing.Size(79, 15);
            this.m_CommentsNumLabel.TabIndex = 11;
            this.m_CommentsNumLabel.Text = "Comments:";
            // 
            // m_FillComments
            // 
            this.m_FillComments.AutoSize = true;
            this.m_FillComments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillComments.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillComments.Location = new System.Drawing.Point(471, 34);
            this.m_FillComments.Name = "m_FillComments";
            this.m_FillComments.Size = new System.Drawing.Size(83, 15);
            this.m_FillComments.TabIndex = 12;
            this.m_FillComments.Text = "FillComments";
            // 
            // m_FillReactions
            // 
            this.m_FillReactions.AutoSize = true;
            this.m_FillReactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillReactions.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillReactions.Location = new System.Drawing.Point(471, 19);
            this.m_FillReactions.Name = "m_FillReactions";
            this.m_FillReactions.Size = new System.Drawing.Size(78, 15);
            this.m_FillReactions.TabIndex = 13;
            this.m_FillReactions.Text = "FillReactions";
            // 
            // m_FillName
            // 
            this.m_FillName.AutoSize = true;
            this.m_FillName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_FillName.ForeColor = System.Drawing.Color.Ivory;
            this.m_FillName.Location = new System.Drawing.Point(471, 4);
            this.m_FillName.MaximumSize = new System.Drawing.Size(100, 0);
            this.m_FillName.Name = "m_FillName";
            this.m_FillName.Size = new System.Drawing.Size(57, 15);
            this.m_FillName.TabIndex = 14;
            this.m_FillName.Text = "FillName";
            // 
            // m_PostTypeChoiceComboBox
            // 
            this.m_PostTypeChoiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostTypeChoiceComboBox.FormattingEnabled = true;
            this.m_PostTypeChoiceComboBox.Items.AddRange(new object[] {
            "Feed",
            "Posts"});
            this.m_PostTypeChoiceComboBox.Location = new System.Drawing.Point(190, 75);
            this.m_PostTypeChoiceComboBox.Name = "m_PostTypeChoiceComboBox";
            this.m_PostTypeChoiceComboBox.Size = new System.Drawing.Size(108, 21);
            this.m_PostTypeChoiceComboBox.TabIndex = 16;
            // 
            // m_ChangeConnectionButton
            // 
            this.m_ChangeConnectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_ChangeConnectionButton.Location = new System.Drawing.Point(304, 75);
            this.m_ChangeConnectionButton.Name = "m_ChangeConnectionButton";
            this.m_ChangeConnectionButton.Size = new System.Drawing.Size(87, 25);
            this.m_ChangeConnectionButton.TabIndex = 17;
            this.m_ChangeConnectionButton.Text = "Chose Type";
            this.m_ChangeConnectionButton.UseVisualStyleBackColor = true;
            this.m_ChangeConnectionButton.Click += new System.EventHandler(this.m_ChangeConnectionButton_Click);
            // 
            // m_FilterButton
            // 
            this.m_FilterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_FilterButton.InfoChoice = FacebookPages.Code.Buttons.eInfoChoice.Filter;
            this.m_FilterButton.Location = new System.Drawing.Point(504, 75);
            this.m_FilterButton.Name = "m_FilterButton";
            this.m_FilterButton.RecivedInfo = null;
            this.m_FilterButton.Size = new System.Drawing.Size(83, 25);
            this.m_FilterButton.TabIndex = 18;
            this.m_FilterButton.Text = "Filter Posts";
            this.m_FilterButton.UseVisualStyleBackColor = true;
            this.m_FilterButton.Click += new System.EventHandler(this.m_FilterButton_Click);
            // 
            // m_PostsList
            // 
            this.m_PostsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostsList.FormattingEnabled = true;
            this.m_PostsList.InfoChoice = FacebookPages.Code.Buttons.eInfoChoice.AppId;
            this.m_PostsList.Items.AddRange(new object[] {
            "(dd/mm/yy)|TYPE| Waiting For Info"});
            this.m_PostsList.Location = new System.Drawing.Point(0, 0);
            this.m_PostsList.Name = "m_PostsList";
            this.m_PostsList.RecivedInfo = null;
            this.m_PostsList.Size = new System.Drawing.Size(391, 69);
            this.m_PostsList.TabIndex = 0;
            this.m_PostsList.SelectedIndexChanged += new System.EventHandler(this.m_PostsList_SelectedIndexChanged);
            // 
            // PostViewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.m_FilterButton);
            this.Controls.Add(this.m_ChangeConnectionButton);
            this.Controls.Add(this.m_PostTypeChoiceComboBox);
            this.Controls.Add(this.m_FillName);
            this.Controls.Add(this.m_FillReactions);
            this.Controls.Add(this.m_FillComments);
            this.Controls.Add(this.m_CommentsNumLabel);
            this.Controls.Add(this.m_ReactionNumLabel);
            this.Controls.Add(this.m_FromLabel);
            this.Controls.Add(this.m_InstructionLabel);
            this.Controls.Add(this.m_PostImage);
            this.Controls.Add(this.m_NumOfPostsInfo);
            this.Controls.Add(this.m_MorePostsButton);
            this.Controls.Add(this.m_PostsList);
            this.Name = "PostViewButton";
            this.Size = new System.Drawing.Size(685, 101);
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button m_MorePostsButton;
        private System.Windows.Forms.TextBox m_NumOfPostsInfo;
        private System.Windows.Forms.PictureBox m_PostImage;
        private System.Windows.Forms.Label m_InstructionLabel;
        protected LoadInfoListBox m_PostsList;
        private System.Windows.Forms.Label m_FromLabel;
        private System.Windows.Forms.Label m_ReactionNumLabel;
        private System.Windows.Forms.Label m_CommentsNumLabel;
        private System.Windows.Forms.Label m_FillComments;
        private System.Windows.Forms.Label m_FillReactions;
        private System.Windows.Forms.Label m_FillName;
        private System.Windows.Forms.ComboBox m_PostTypeChoiceComboBox;
        private System.Windows.Forms.Button m_ChangeConnectionButton;
        private FacebookPages.Buttons.LoadInfoButton m_FilterButton;
    }
}
