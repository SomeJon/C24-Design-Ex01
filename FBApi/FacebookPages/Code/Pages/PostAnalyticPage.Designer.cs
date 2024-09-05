    namespace FacebookPages.Code.Pages
    {
        partial class PostAnalyticPage
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
            this.m_ReturnSwitchButton = new FacebookPages.Buttons.PageSwitchButton();
            this.m_EngagementMetricsHeader = new System.Windows.Forms.Label();
            this.m_TotalLikesLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_EngagementMetricsButton = new System.Windows.Forms.Button();
            this.m_TotalCommentsLabel = new System.Windows.Forms.Label();
            this.m_EngagementRateLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_ContentPerformanceButton = new System.Windows.Forms.Button();
            this.m_TopPerformingListBox = new FacebookPages.Code.Buttons.LoadInfoListBox();
            this.m_PostFrequencyLabel = new System.Windows.Forms.Label();
            this.m_PostTimingImpactLabel = new System.Windows.Forms.Label();
            this.m_ContentPerformanceHeader = new System.Windows.Forms.Label();
            this.m_TopPerformingPostsLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_PostFrequencyTimingButton = new System.Windows.Forms.Button();
            this.m_FrequencyImpactLabel = new System.Windows.Forms.Label();
            this.m_PostFrequencyTimingHeader = new System.Windows.Forms.Label();
            this.m_OptimalPostTimingLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.PostTypeAnalysisButton = new System.Windows.Forms.Button();
            this.m_TotatlTypeCommments = new System.Windows.Forms.Label();
            this.m_AverageTypeEngagement = new System.Windows.Forms.Label();
            this.m_ChoseType = new System.Windows.Forms.ComboBox();
            this.m_TotalTypeLikes = new System.Windows.Forms.Label();
            this.PostTypeAnalysisHeader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_ReturnSwitchButton
            // 
            this.m_ReturnSwitchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.m_ReturnSwitchButton.Location = new System.Drawing.Point(3, 3);
            this.m_ReturnSwitchButton.Name = "m_ReturnSwitchButton";
            this.m_ReturnSwitchButton.PageChoice = FacebookPages.Code.Buttons.ePageChoice.WallPage;
            this.m_ReturnSwitchButton.Size = new System.Drawing.Size(77, 46);
            this.m_ReturnSwitchButton.TabIndex = 0;
            this.m_ReturnSwitchButton.Text = "Return";
            this.m_ReturnSwitchButton.UseVisualStyleBackColor = true;
            this.m_ReturnSwitchButton.Click += new System.EventHandler(this.m_ReturnSwitchButton_Click);
            // 
            // m_EngagementMetricsHeader
            // 
            this.m_EngagementMetricsHeader.AutoSize = true;
            this.m_EngagementMetricsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_EngagementMetricsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_EngagementMetricsHeader.Location = new System.Drawing.Point(12, 12);
            this.m_EngagementMetricsHeader.Name = "m_EngagementMetricsHeader";
            this.m_EngagementMetricsHeader.Size = new System.Drawing.Size(162, 18);
            this.m_EngagementMetricsHeader.TabIndex = 1;
            this.m_EngagementMetricsHeader.Text = "Engagement Metrics";
            // 
            // m_TotalLikesLabel
            // 
            this.m_TotalLikesLabel.AutoSize = true;
            this.m_TotalLikesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotalLikesLabel.Location = new System.Drawing.Point(13, 37);
            this.m_TotalLikesLabel.Name = "m_TotalLikesLabel";
            this.m_TotalLikesLabel.Size = new System.Drawing.Size(59, 13);
            this.m_TotalLikesLabel.TabIndex = 2;
            this.m_TotalLikesLabel.Text = "Total Likes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.m_EngagementMetricsButton);
            this.panel1.Controls.Add(this.m_TotalCommentsLabel);
            this.panel1.Controls.Add(this.m_EngagementRateLabel);
            this.panel1.Controls.Add(this.m_EngagementMetricsHeader);
            this.panel1.Controls.Add(this.m_TotalLikesLabel);
            this.panel1.Location = new System.Drawing.Point(98, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 95);
            this.panel1.TabIndex = 3;
            // 
            // m_EngagementMetricsButton
            // 
            this.m_EngagementMetricsButton.Location = new System.Drawing.Point(267, 11);
            this.m_EngagementMetricsButton.Name = "m_EngagementMetricsButton";
            this.m_EngagementMetricsButton.Size = new System.Drawing.Size(60, 26);
            this.m_EngagementMetricsButton.TabIndex = 6;
            this.m_EngagementMetricsButton.Text = "Load";
            this.m_EngagementMetricsButton.UseVisualStyleBackColor = true;
            this.m_EngagementMetricsButton.Click += new System.EventHandler(this.m_EngagementMetricsButton_Click);
            // 
            // m_TotalCommentsLabel
            // 
            this.m_TotalCommentsLabel.AutoSize = true;
            this.m_TotalCommentsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotalCommentsLabel.Location = new System.Drawing.Point(13, 59);
            this.m_TotalCommentsLabel.Name = "m_TotalCommentsLabel";
            this.m_TotalCommentsLabel.Size = new System.Drawing.Size(83, 13);
            this.m_TotalCommentsLabel.TabIndex = 4;
            this.m_TotalCommentsLabel.Text = "Total Comments";
            // 
            // m_EngagementRateLabel
            // 
            this.m_EngagementRateLabel.AutoSize = true;
            this.m_EngagementRateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_EngagementRateLabel.Location = new System.Drawing.Point(12, 78);
            this.m_EngagementRateLabel.Name = "m_EngagementRateLabel";
            this.m_EngagementRateLabel.Size = new System.Drawing.Size(93, 13);
            this.m_EngagementRateLabel.TabIndex = 3;
            this.m_EngagementRateLabel.Text = "Engagement Rate";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.m_ContentPerformanceButton);
            this.panel2.Controls.Add(this.m_TopPerformingListBox);
            this.panel2.Controls.Add(this.m_PostFrequencyLabel);
            this.panel2.Controls.Add(this.m_PostTimingImpactLabel);
            this.panel2.Controls.Add(this.m_ContentPerformanceHeader);
            this.panel2.Controls.Add(this.m_TopPerformingPostsLabel);
            this.panel2.Location = new System.Drawing.Point(3, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 194);
            this.panel2.TabIndex = 5;
            // 
            // m_ContentPerformanceButton
            // 
            this.m_ContentPerformanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ContentPerformanceButton.Location = new System.Drawing.Point(662, 5);
            this.m_ContentPerformanceButton.Name = "m_ContentPerformanceButton";
            this.m_ContentPerformanceButton.Size = new System.Drawing.Size(60, 26);
            this.m_ContentPerformanceButton.TabIndex = 6;
            this.m_ContentPerformanceButton.Text = "Load";
            this.m_ContentPerformanceButton.UseVisualStyleBackColor = true;
            this.m_ContentPerformanceButton.Click += new System.EventHandler(this.m_ContentPerformanceButton_Click);
            // 
            // m_TopPerformingListBox
            // 
            this.m_TopPerformingListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_TopPerformingListBox.FormattingEnabled = true;
            this.m_TopPerformingListBox.InfoChoice = FacebookPages.Code.Buttons.eInfoChoice.Post;
            this.m_TopPerformingListBox.Items.AddRange(new object[] {
            "Waiting for data...."});
            this.m_TopPerformingListBox.Location = new System.Drawing.Point(3, 104);
            this.m_TopPerformingListBox.Name = "m_TopPerformingListBox";
            this.m_TopPerformingListBox.RecivedInfo = null;
            this.m_TopPerformingListBox.Size = new System.Drawing.Size(722, 82);
            this.m_TopPerformingListBox.TabIndex = 5;
            this.m_TopPerformingListBox.DoubleClick += new System.EventHandler(this.m_TopPerformingListBox_DoubleClick);
            // 
            // m_PostFrequencyLabel
            // 
            this.m_PostFrequencyLabel.AutoSize = true;
            this.m_PostFrequencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_PostFrequencyLabel.Location = new System.Drawing.Point(3, 42);
            this.m_PostFrequencyLabel.Name = "m_PostFrequencyLabel";
            this.m_PostFrequencyLabel.Size = new System.Drawing.Size(81, 13);
            this.m_PostFrequencyLabel.TabIndex = 4;
            this.m_PostFrequencyLabel.Text = "Post Frequency";
            // 
            // m_PostTimingImpactLabel
            // 
            this.m_PostTimingImpactLabel.AutoSize = true;
            this.m_PostTimingImpactLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_PostTimingImpactLabel.Location = new System.Drawing.Point(3, 63);
            this.m_PostTimingImpactLabel.Name = "m_PostTimingImpactLabel";
            this.m_PostTimingImpactLabel.Size = new System.Drawing.Size(97, 13);
            this.m_PostTimingImpactLabel.TabIndex = 3;
            this.m_PostTimingImpactLabel.Text = "Post Timing Impact";
            // 
            // m_ContentPerformanceHeader
            // 
            this.m_ContentPerformanceHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.m_ContentPerformanceHeader.AutoSize = true;
            this.m_ContentPerformanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ContentPerformanceHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ContentPerformanceHeader.Location = new System.Drawing.Point(276, 5);
            this.m_ContentPerformanceHeader.Name = "m_ContentPerformanceHeader";
            this.m_ContentPerformanceHeader.Size = new System.Drawing.Size(169, 18);
            this.m_ContentPerformanceHeader.TabIndex = 1;
            this.m_ContentPerformanceHeader.Text = "Content Performance";
            // 
            // m_TopPerformingPostsLabel
            // 
            this.m_TopPerformingPostsLabel.AutoSize = true;
            this.m_TopPerformingPostsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TopPerformingPostsLabel.Location = new System.Drawing.Point(3, 82);
            this.m_TopPerformingPostsLabel.Name = "m_TopPerformingPostsLabel";
            this.m_TopPerformingPostsLabel.Size = new System.Drawing.Size(253, 13);
            this.m_TopPerformingPostsLabel.TabIndex = 2;
            this.m_TopPerformingPostsLabel.Text = "Top Performing Posts (Click twice on post to enter it)";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.m_PostFrequencyTimingButton);
            this.panel3.Controls.Add(this.m_FrequencyImpactLabel);
            this.panel3.Controls.Add(this.m_PostFrequencyTimingHeader);
            this.panel3.Controls.Add(this.m_OptimalPostTimingLabel);
            this.panel3.Location = new System.Drawing.Point(3, 104);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(427, 111);
            this.panel3.TabIndex = 5;
            // 
            // m_PostFrequencyTimingButton
            // 
            this.m_PostFrequencyTimingButton.Location = new System.Drawing.Point(362, 3);
            this.m_PostFrequencyTimingButton.Name = "m_PostFrequencyTimingButton";
            this.m_PostFrequencyTimingButton.Size = new System.Drawing.Size(60, 26);
            this.m_PostFrequencyTimingButton.TabIndex = 5;
            this.m_PostFrequencyTimingButton.Text = "Load";
            this.m_PostFrequencyTimingButton.UseVisualStyleBackColor = true;
            this.m_PostFrequencyTimingButton.Click += new System.EventHandler(this.m_PostFrequencyTimingButton_Click);
            // 
            // m_FrequencyImpactLabel
            // 
            this.m_FrequencyImpactLabel.AutoSize = true;
            this.m_FrequencyImpactLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_FrequencyImpactLabel.Location = new System.Drawing.Point(5, 70);
            this.m_FrequencyImpactLabel.Name = "m_FrequencyImpactLabel";
            this.m_FrequencyImpactLabel.Size = new System.Drawing.Size(92, 13);
            this.m_FrequencyImpactLabel.TabIndex = 4;
            this.m_FrequencyImpactLabel.Text = "Frequency Impact";
            // 
            // m_PostFrequencyTimingHeader
            // 
            this.m_PostFrequencyTimingHeader.AutoSize = true;
            this.m_PostFrequencyTimingHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_PostFrequencyTimingHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_PostFrequencyTimingHeader.Location = new System.Drawing.Point(3, 10);
            this.m_PostFrequencyTimingHeader.Name = "m_PostFrequencyTimingHeader";
            this.m_PostFrequencyTimingHeader.Size = new System.Drawing.Size(213, 18);
            this.m_PostFrequencyTimingHeader.TabIndex = 1;
            this.m_PostFrequencyTimingHeader.Text = "Post Frequency and Timing";
            // 
            // m_OptimalPostTimingLabel
            // 
            this.m_OptimalPostTimingLabel.AutoSize = true;
            this.m_OptimalPostTimingLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_OptimalPostTimingLabel.Location = new System.Drawing.Point(5, 43);
            this.m_OptimalPostTimingLabel.Name = "m_OptimalPostTimingLabel";
            this.m_OptimalPostTimingLabel.Size = new System.Drawing.Size(100, 13);
            this.m_OptimalPostTimingLabel.TabIndex = 2;
            this.m_OptimalPostTimingLabel.Text = "Optimal Post Timing";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.PostTypeAnalysisButton);
            this.panel4.Controls.Add(this.m_TotatlTypeCommments);
            this.panel4.Controls.Add(this.m_AverageTypeEngagement);
            this.panel4.Controls.Add(this.m_ChoseType);
            this.panel4.Controls.Add(this.m_TotalTypeLikes);
            this.panel4.Controls.Add(this.PostTypeAnalysisHeader);
            this.panel4.Location = new System.Drawing.Point(434, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(297, 212);
            this.panel4.TabIndex = 6;
            // 
            // PostTypeAnalysisButton
            // 
            this.PostTypeAnalysisButton.Location = new System.Drawing.Point(16, 12);
            this.PostTypeAnalysisButton.Name = "PostTypeAnalysisButton";
            this.PostTypeAnalysisButton.Size = new System.Drawing.Size(60, 26);
            this.PostTypeAnalysisButton.TabIndex = 7;
            this.PostTypeAnalysisButton.Text = "Load";
            this.PostTypeAnalysisButton.UseVisualStyleBackColor = true;
            this.PostTypeAnalysisButton.Click += new System.EventHandler(this.PostTypeAnalysisButton_Click);
            // 
            // m_TotatlTypeCommments
            // 
            this.m_TotatlTypeCommments.AutoSize = true;
            this.m_TotatlTypeCommments.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotatlTypeCommments.Location = new System.Drawing.Point(25, 144);
            this.m_TotatlTypeCommments.Name = "m_TotatlTypeCommments";
            this.m_TotatlTypeCommments.Size = new System.Drawing.Size(83, 13);
            this.m_TotatlTypeCommments.TabIndex = 7;
            this.m_TotatlTypeCommments.Text = "Total Comments";
            // 
            // m_AverageTypeEngagement
            // 
            this.m_AverageTypeEngagement.AutoSize = true;
            this.m_AverageTypeEngagement.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_AverageTypeEngagement.Location = new System.Drawing.Point(25, 171);
            this.m_AverageTypeEngagement.Name = "m_AverageTypeEngagement";
            this.m_AverageTypeEngagement.Size = new System.Drawing.Size(110, 13);
            this.m_AverageTypeEngagement.TabIndex = 6;
            this.m_AverageTypeEngagement.Text = "Average Engagement";
            // 
            // m_ChoseType
            // 
            this.m_ChoseType.FormattingEnabled = true;
            this.m_ChoseType.Location = new System.Drawing.Point(28, 74);
            this.m_ChoseType.Name = "m_ChoseType";
            this.m_ChoseType.Size = new System.Drawing.Size(155, 21);
            this.m_ChoseType.TabIndex = 5;
            this.m_ChoseType.SelectedIndexChanged += new System.EventHandler(this.m_ChoseType_SelectedIndexChanged);
            // 
            // m_TotalTypeLikes
            // 
            this.m_TotalTypeLikes.AutoSize = true;
            this.m_TotalTypeLikes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotalTypeLikes.Location = new System.Drawing.Point(25, 117);
            this.m_TotalTypeLikes.Name = "m_TotalTypeLikes";
            this.m_TotalTypeLikes.Size = new System.Drawing.Size(59, 13);
            this.m_TotalTypeLikes.TabIndex = 4;
            this.m_TotalTypeLikes.Text = "Total Likes";
            // 
            // PostTypeAnalysisHeader
            // 
            this.PostTypeAnalysisHeader.AutoSize = true;
            this.PostTypeAnalysisHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTypeAnalysisHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostTypeAnalysisHeader.Location = new System.Drawing.Point(82, 14);
            this.PostTypeAnalysisHeader.Name = "PostTypeAnalysisHeader";
            this.PostTypeAnalysisHeader.Size = new System.Drawing.Size(151, 18);
            this.PostTypeAnalysisHeader.TabIndex = 1;
            this.PostTypeAnalysisHeader.Text = "Post Type Analysis";
            // 
            // PostAnalyticPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_ReturnSwitchButton);
            this.Name = "PostAnalyticPage";
            this.Size = new System.Drawing.Size(734, 418);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private FacebookPages.Buttons.PageSwitchButton m_ReturnSwitchButton;
            private System.Windows.Forms.Label m_EngagementMetricsHeader;
            private System.Windows.Forms.Label m_TotalLikesLabel;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Label m_TotalCommentsLabel;
            private System.Windows.Forms.Label m_EngagementRateLabel;
            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.Label m_PostFrequencyLabel;
            private System.Windows.Forms.Label m_PostTimingImpactLabel;
            private System.Windows.Forms.Label m_ContentPerformanceHeader;
            private System.Windows.Forms.Label m_TopPerformingPostsLabel;
            private Buttons.LoadInfoListBox m_TopPerformingListBox;
            private System.Windows.Forms.Panel panel3;
            private System.Windows.Forms.Label m_FrequencyImpactLabel;
            private System.Windows.Forms.Label m_PostFrequencyTimingHeader;
            private System.Windows.Forms.Label m_OptimalPostTimingLabel;
            private System.Windows.Forms.Panel panel4;
            private System.Windows.Forms.Label m_TotalTypeLikes;
            private System.Windows.Forms.Label PostTypeAnalysisHeader;
            private System.Windows.Forms.ComboBox m_ChoseType;
            private System.Windows.Forms.Button m_EngagementMetricsButton;
            private System.Windows.Forms.Button m_ContentPerformanceButton;
            private System.Windows.Forms.Button m_PostFrequencyTimingButton;
            private System.Windows.Forms.Label m_TotatlTypeCommments;
            private System.Windows.Forms.Label m_AverageTypeEngagement;
        private System.Windows.Forms.Button PostTypeAnalysisButton;
    }
    }
