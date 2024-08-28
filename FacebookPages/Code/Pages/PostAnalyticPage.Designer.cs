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
            this.m_EngagementRateLabel = new System.Windows.Forms.Label();
            this.m_TotalCommentsLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.m_PostFrequencyLabel = new System.Windows.Forms.Label();
            this.m_PostTimingImpactLabel = new System.Windows.Forms.Label();
            this.m_ContentPerformanceHeader = new System.Windows.Forms.Label();
            this.m_TopPerformingPostsLabel = new System.Windows.Forms.Label();
            this.loadInfoListBox1 = new FacebookPages.Code.Buttons.LoadInfoListBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.m_FrequencyImpactLabel = new System.Windows.Forms.Label();
            this.m_PostFrequencyTimingHeader = new System.Windows.Forms.Label();
            this.m_OptimalPostTimingLabel = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_FormatEfficiencyLabel = new System.Windows.Forms.Label();
            this.PostTypeAnalysisHeader = new System.Windows.Forms.Label();
            this.m_TypeBasedPerformanceLabel = new System.Windows.Forms.Label();
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
            // 
            // m_EngagementMetricsHeader
            // 
            this.m_EngagementMetricsHeader.AutoSize = true;
            this.m_EngagementMetricsHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_EngagementMetricsHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_EngagementMetricsHeader.Location = new System.Drawing.Point(22, 10);
            this.m_EngagementMetricsHeader.Name = "m_EngagementMetricsHeader";
            this.m_EngagementMetricsHeader.Size = new System.Drawing.Size(162, 18);
            this.m_EngagementMetricsHeader.TabIndex = 1;
            this.m_EngagementMetricsHeader.Text = "Engagement Metrics";
            // 
            // m_TotalLikesLabel
            // 
            this.m_TotalLikesLabel.AutoSize = true;
            this.m_TotalLikesLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotalLikesLabel.Location = new System.Drawing.Point(25, 42);
            this.m_TotalLikesLabel.Name = "m_TotalLikesLabel";
            this.m_TotalLikesLabel.Size = new System.Drawing.Size(82, 13);
            this.m_TotalLikesLabel.TabIndex = 2;
            this.m_TotalLikesLabel.Text = "TotalLikesLabel";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.m_TotalCommentsLabel);
            this.panel1.Controls.Add(this.m_EngagementRateLabel);
            this.panel1.Controls.Add(this.m_EngagementMetricsHeader);
            this.panel1.Controls.Add(this.m_TotalLikesLabel);
            this.panel1.Location = new System.Drawing.Point(3, 55);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 160);
            this.panel1.TabIndex = 3;
            // 
            // m_EngagementRateLabel
            // 
            this.m_EngagementRateLabel.AutoSize = true;
            this.m_EngagementRateLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_EngagementRateLabel.Location = new System.Drawing.Point(25, 120);
            this.m_EngagementRateLabel.Name = "m_EngagementRateLabel";
            this.m_EngagementRateLabel.Size = new System.Drawing.Size(116, 13);
            this.m_EngagementRateLabel.TabIndex = 3;
            this.m_EngagementRateLabel.Text = "EngagementRateLabel";
            // 
            // m_TotalCommentsLabel
            // 
            this.m_TotalCommentsLabel.AutoSize = true;
            this.m_TotalCommentsLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TotalCommentsLabel.Location = new System.Drawing.Point(25, 82);
            this.m_TotalCommentsLabel.Name = "m_TotalCommentsLabel";
            this.m_TotalCommentsLabel.Size = new System.Drawing.Size(106, 13);
            this.m_TotalCommentsLabel.TabIndex = 4;
            this.m_TotalCommentsLabel.Text = "TotalCommentsLabel";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.loadInfoListBox1);
            this.panel2.Controls.Add(this.m_PostFrequencyLabel);
            this.panel2.Controls.Add(this.m_PostTimingImpactLabel);
            this.panel2.Controls.Add(this.m_ContentPerformanceHeader);
            this.panel2.Controls.Add(this.m_TopPerformingPostsLabel);
            this.panel2.Location = new System.Drawing.Point(3, 221);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(619, 194);
            this.panel2.TabIndex = 5;
            // 
            // m_PostFrequencyLabel
            // 
            this.m_PostFrequencyLabel.AutoSize = true;
            this.m_PostFrequencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_PostFrequencyLabel.Location = new System.Drawing.Point(3, 42);
            this.m_PostFrequencyLabel.Name = "m_PostFrequencyLabel";
            this.m_PostFrequencyLabel.Size = new System.Drawing.Size(104, 13);
            this.m_PostFrequencyLabel.TabIndex = 4;
            this.m_PostFrequencyLabel.Text = "PostFrequencyLabel";
            // 
            // m_PostTimingImpactLabel
            // 
            this.m_PostTimingImpactLabel.AutoSize = true;
            this.m_PostTimingImpactLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_PostTimingImpactLabel.Location = new System.Drawing.Point(3, 63);
            this.m_PostTimingImpactLabel.Name = "m_PostTimingImpactLabel";
            this.m_PostTimingImpactLabel.Size = new System.Drawing.Size(117, 13);
            this.m_PostTimingImpactLabel.TabIndex = 3;
            this.m_PostTimingImpactLabel.Text = "PostTimingImpactLabel";
            // 
            // m_ContentPerformanceHeader
            // 
            this.m_ContentPerformanceHeader.AutoSize = true;
            this.m_ContentPerformanceHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ContentPerformanceHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_ContentPerformanceHeader.Location = new System.Drawing.Point(214, 11);
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
            // loadInfoListBox1
            // 
            this.loadInfoListBox1.FormattingEnabled = true;
            this.loadInfoListBox1.InfoChoice = FacebookPages.Code.Buttons.eInfoChoice.AppId;
            this.loadInfoListBox1.Location = new System.Drawing.Point(3, 104);
            this.loadInfoListBox1.Name = "loadInfoListBox1";
            this.loadInfoListBox1.RecivedInfo = null;
            this.loadInfoListBox1.Size = new System.Drawing.Size(613, 82);
            this.loadInfoListBox1.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Controls.Add(this.m_FrequencyImpactLabel);
            this.panel3.Controls.Add(this.m_PostFrequencyTimingHeader);
            this.panel3.Controls.Add(this.m_OptimalPostTimingLabel);
            this.panel3.Location = new System.Drawing.Point(212, 55);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(221, 160);
            this.panel3.TabIndex = 5;
            // 
            // m_FrequencyImpactLabel
            // 
            this.m_FrequencyImpactLabel.AutoSize = true;
            this.m_FrequencyImpactLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_FrequencyImpactLabel.Location = new System.Drawing.Point(25, 82);
            this.m_FrequencyImpactLabel.Name = "m_FrequencyImpactLabel";
            this.m_FrequencyImpactLabel.Size = new System.Drawing.Size(115, 13);
            this.m_FrequencyImpactLabel.TabIndex = 4;
            this.m_FrequencyImpactLabel.Text = "FrequencyImpactLabel";
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
            this.m_OptimalPostTimingLabel.Location = new System.Drawing.Point(25, 42);
            this.m_OptimalPostTimingLabel.Name = "m_OptimalPostTimingLabel";
            this.m_OptimalPostTimingLabel.Size = new System.Drawing.Size(120, 13);
            this.m_OptimalPostTimingLabel.TabIndex = 2;
            this.m_OptimalPostTimingLabel.Text = "OptimalPostTimingLabel";
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Controls.Add(this.m_FormatEfficiencyLabel);
            this.panel4.Controls.Add(this.PostTypeAnalysisHeader);
            this.panel4.Controls.Add(this.m_TypeBasedPerformanceLabel);
            this.panel4.Location = new System.Drawing.Point(434, 55);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(188, 160);
            this.panel4.TabIndex = 6;
            // 
            // m_FormatEfficiencyLabel
            // 
            this.m_FormatEfficiencyLabel.AutoSize = true;
            this.m_FormatEfficiencyLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_FormatEfficiencyLabel.Location = new System.Drawing.Point(25, 82);
            this.m_FormatEfficiencyLabel.Name = "m_FormatEfficiencyLabel";
            this.m_FormatEfficiencyLabel.Size = new System.Drawing.Size(111, 13);
            this.m_FormatEfficiencyLabel.TabIndex = 4;
            this.m_FormatEfficiencyLabel.Text = "FormatEfficiencyLabel";
            // 
            // PostTypeAnalysisHeader
            // 
            this.PostTypeAnalysisHeader.AutoSize = true;
            this.PostTypeAnalysisHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostTypeAnalysisHeader.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PostTypeAnalysisHeader.Location = new System.Drawing.Point(17, 10);
            this.PostTypeAnalysisHeader.Name = "PostTypeAnalysisHeader";
            this.PostTypeAnalysisHeader.Size = new System.Drawing.Size(151, 18);
            this.PostTypeAnalysisHeader.TabIndex = 1;
            this.PostTypeAnalysisHeader.Text = "Post Type Analysis";
            // 
            // m_TypeBasedPerformanceLabel
            // 
            this.m_TypeBasedPerformanceLabel.AutoSize = true;
            this.m_TypeBasedPerformanceLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.m_TypeBasedPerformanceLabel.Location = new System.Drawing.Point(25, 42);
            this.m_TypeBasedPerformanceLabel.Name = "m_TypeBasedPerformanceLabel";
            this.m_TypeBasedPerformanceLabel.Size = new System.Drawing.Size(147, 13);
            this.m_TypeBasedPerformanceLabel.TabIndex = 2;
            this.m_TypeBasedPerformanceLabel.Text = "TypeBasedPerformanceLabel";
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
            this.Size = new System.Drawing.Size(625, 418);
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
        private Buttons.LoadInfoListBox loadInfoListBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label m_FrequencyImpactLabel;
        private System.Windows.Forms.Label m_PostFrequencyTimingHeader;
        private System.Windows.Forms.Label m_OptimalPostTimingLabel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label m_FormatEfficiencyLabel;
        private System.Windows.Forms.Label PostTypeAnalysisHeader;
        private System.Windows.Forms.Label m_TypeBasedPerformanceLabel;
    }
}
