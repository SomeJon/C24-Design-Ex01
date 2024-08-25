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
            this.m_PostsList = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m_NumOfPostsInfo = new System.Windows.Forms.TextBox();
            this.m_PostTypeChoice = new System.Windows.Forms.ListBox();
            this.m_PostShortDataList = new System.Windows.Forms.ListBox();
            this.m_PostImage = new System.Windows.Forms.PictureBox();
            this.m_InstructionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).BeginInit();
            this.SuspendLayout();
            // 
            // m_PostsList
            // 
            this.m_PostsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostsList.FormattingEnabled = true;
            this.m_PostsList.Items.AddRange(new object[] {
            "1. (dd/mm/yy) TimTim: hello world",
            "2. ",
            "3. ",
            "4. ",
            "5. ",
            "6. ",
            "7. ",
            "8. "});
            this.m_PostsList.Location = new System.Drawing.Point(0, 0);
            this.m_PostsList.Name = "m_PostsList";
            this.m_PostsList.Size = new System.Drawing.Size(391, 69);
            this.m_PostsList.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(470, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 25);
            this.button1.TabIndex = 1;
            this.button1.Text = "More posts";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // m_NumOfPostsInfo
            // 
            this.m_NumOfPostsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_NumOfPostsInfo.Location = new System.Drawing.Point(365, 80);
            this.m_NumOfPostsInfo.Name = "m_NumOfPostsInfo";
            this.m_NumOfPostsInfo.Size = new System.Drawing.Size(99, 20);
            this.m_NumOfPostsInfo.TabIndex = 3;
            this.m_NumOfPostsInfo.Text = "Showing - 25 posts";
            // 
            // m_PostTypeChoice
            // 
            this.m_PostTypeChoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_PostTypeChoice.FormattingEnabled = true;
            this.m_PostTypeChoice.Items.AddRange(new object[] {
            "Feed",
            "Posts"});
            this.m_PostTypeChoice.Location = new System.Drawing.Point(276, 81);
            this.m_PostTypeChoice.Name = "m_PostTypeChoice";
            this.m_PostTypeChoice.Size = new System.Drawing.Size(83, 17);
            this.m_PostTypeChoice.TabIndex = 4;
            // 
            // m_PostShortDataList
            // 
            this.m_PostShortDataList.FormattingEnabled = true;
            this.m_PostShortDataList.Items.AddRange(new object[] {
            "From: ",
            "Reactions:",
            "Comments:"});
            this.m_PostShortDataList.Location = new System.Drawing.Point(396, 0);
            this.m_PostShortDataList.Name = "m_PostShortDataList";
            this.m_PostShortDataList.Size = new System.Drawing.Size(147, 43);
            this.m_PostShortDataList.TabIndex = 5;
            // 
            // m_PostImage
            // 
            this.m_PostImage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostImage.Location = new System.Drawing.Point(549, 0);
            this.m_PostImage.Name = "m_PostImage";
            this.m_PostImage.Size = new System.Drawing.Size(103, 71);
            this.m_PostImage.TabIndex = 6;
            this.m_PostImage.TabStop = false;
            // 
            // m_InstructionLabel
            // 
            this.m_InstructionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.m_InstructionLabel.AutoSize = true;
            this.m_InstructionLabel.Location = new System.Drawing.Point(3, 87);
            this.m_InstructionLabel.Name = "m_InstructionLabel";
            this.m_InstructionLabel.Size = new System.Drawing.Size(258, 13);
            this.m_InstructionLabel.TabIndex = 7;
            this.m_InstructionLabel.Text = "(Single click to view short data, double click for more)";
            // 
            // PostViewButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.m_InstructionLabel);
            this.Controls.Add(this.m_PostImage);
            this.Controls.Add(this.m_PostShortDataList);
            this.Controls.Add(this.m_PostTypeChoice);
            this.Controls.Add(this.m_NumOfPostsInfo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_PostsList);
            this.Name = "PostViewButton";
            this.Size = new System.Drawing.Size(652, 101);
            ((System.ComponentModel.ISupportInitialize)(this.m_PostImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox m_PostsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox m_NumOfPostsInfo;
        private System.Windows.Forms.ListBox m_PostTypeChoice;
        private System.Windows.Forms.ListBox m_PostShortDataList;
        private System.Windows.Forms.PictureBox m_PostImage;
        private System.Windows.Forms.Label m_InstructionLabel;
    }
}
