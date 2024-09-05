namespace FacebookClient.Code
{
    partial class PostView
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
            this.m_ExitButton = new System.Windows.Forms.Button();
            this.m_LikesLabel = new System.Windows.Forms.Label();
            this.m_CommeantsLable = new System.Windows.Forms.Label();
            this.m_PublisherSmallPicture = new System.Windows.Forms.PictureBox();
            this.m_PostPicture = new System.Windows.Forms.PictureBox();
            this.m_PostTypeLabel = new System.Windows.Forms.Label();
            this.m_FullNameLabel = new System.Windows.Forms.Label();
            this.m_PublishedDate = new System.Windows.Forms.Label();
            this.m_LastModifiedDate = new System.Windows.Forms.Label();
            this.m_MessageBox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_PublisherSmallPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ExitButton
            // 
            this.m_ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_ExitButton.Location = new System.Drawing.Point(14, 7);
            this.m_ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m_ExitButton.Name = "m_ExitButton";
            this.m_ExitButton.Size = new System.Drawing.Size(70, 39);
            this.m_ExitButton.TabIndex = 2;
            this.m_ExitButton.Text = "Exit";
            this.m_ExitButton.UseVisualStyleBackColor = true;
            this.m_ExitButton.Click += new System.EventHandler(this.m_ExitButton_Click);
            // 
            // m_LikesLabel
            // 
            this.m_LikesLabel.AutoSize = true;
            this.m_LikesLabel.Location = new System.Drawing.Point(194, 31);
            this.m_LikesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LikesLabel.Name = "m_LikesLabel";
            this.m_LikesLabel.Size = new System.Drawing.Size(61, 15);
            this.m_LikesLabel.TabIndex = 3;
            this.m_LikesLabel.Text = "Likes: N\\A";
            // 
            // m_CommeantsLable
            // 
            this.m_CommeantsLable.AutoSize = true;
            this.m_CommeantsLable.Location = new System.Drawing.Point(156, 49);
            this.m_CommeantsLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_CommeantsLable.Name = "m_CommeantsLable";
            this.m_CommeantsLable.Size = new System.Drawing.Size(99, 15);
            this.m_CommeantsLable.TabIndex = 4;
            this.m_CommeantsLable.Text = "Commeants: N\\A";
            // 
            // m_PublisherSmallPicture
            // 
            this.m_PublisherSmallPicture.Location = new System.Drawing.Point(92, 9);
            this.m_PublisherSmallPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m_PublisherSmallPicture.Name = "m_PublisherSmallPicture";
            this.m_PublisherSmallPicture.Size = new System.Drawing.Size(58, 51);
            this.m_PublisherSmallPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PublisherSmallPicture.TabIndex = 1;
            this.m_PublisherSmallPicture.TabStop = false;
            // 
            // m_PostPicture
            // 
            this.m_PostPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostPicture.Location = new System.Drawing.Point(248, 94);
            this.m_PostPicture.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.m_PostPicture.Name = "m_PostPicture";
            this.m_PostPicture.Size = new System.Drawing.Size(328, 315);
            this.m_PostPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.m_PostPicture.TabIndex = 0;
            this.m_PostPicture.TabStop = false;
            // 
            // m_PostTypeLabel
            // 
            this.m_PostTypeLabel.AutoSize = true;
            this.m_PostTypeLabel.Location = new System.Drawing.Point(170, 9);
            this.m_PostTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_PostTypeLabel.Name = "m_PostTypeLabel";
            this.m_PostTypeLabel.Size = new System.Drawing.Size(85, 15);
            this.m_PostTypeLabel.TabIndex = 5;
            this.m_PostTypeLabel.Text = "Post Type: N\\A";
            // 
            // m_FullNameLabel
            // 
            this.m_FullNameLabel.AutoSize = true;
            this.m_FullNameLabel.Location = new System.Drawing.Point(89, 71);
            this.m_FullNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_FullNameLabel.Name = "m_FullNameLabel";
            this.m_FullNameLabel.Size = new System.Drawing.Size(114, 15);
            this.m_FullNameLabel.TabIndex = 6;
            this.m_FullNameLabel.Text = "Full Name Of Writer";
            // 
            // m_PublishedDate
            // 
            this.m_PublishedDate.AutoSize = true;
            this.m_PublishedDate.Location = new System.Drawing.Point(344, 9);
            this.m_PublishedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_PublishedDate.Name = "m_PublishedDate";
            this.m_PublishedDate.Size = new System.Drawing.Size(91, 15);
            this.m_PublishedDate.TabIndex = 7;
            this.m_PublishedDate.Text = "Date Published";
            // 
            // m_LastModifiedDate
            // 
            this.m_LastModifiedDate.AutoSize = true;
            this.m_LastModifiedDate.Location = new System.Drawing.Point(344, 31);
            this.m_LastModifiedDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.m_LastModifiedDate.Name = "m_LastModifiedDate";
            this.m_LastModifiedDate.Size = new System.Drawing.Size(81, 15);
            this.m_LastModifiedDate.TabIndex = 8;
            this.m_LastModifiedDate.Text = "Last Modified";
            // 
            // m_MessageBox
            // 
            this.m_MessageBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.m_MessageBox.Location = new System.Drawing.Point(10, 94);
            this.m_MessageBox.Name = "m_MessageBox";
            this.m_MessageBox.Size = new System.Drawing.Size(231, 316);
            this.m_MessageBox.TabIndex = 9;
            this.m_MessageBox.Text = "";
            // 
            // PostView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(589, 421);
            this.Controls.Add(this.m_MessageBox);
            this.Controls.Add(this.m_LastModifiedDate);
            this.Controls.Add(this.m_PublishedDate);
            this.Controls.Add(this.m_FullNameLabel);
            this.Controls.Add(this.m_PostTypeLabel);
            this.Controls.Add(this.m_CommeantsLable);
            this.Controls.Add(this.m_LikesLabel);
            this.Controls.Add(this.m_ExitButton);
            this.Controls.Add(this.m_PublisherSmallPicture);
            this.Controls.Add(this.m_PostPicture);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "PostView";
            this.Text = "Post View";
            ((System.ComponentModel.ISupportInitialize)(this.m_PublisherSmallPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_PostPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox m_PostPicture;
        private System.Windows.Forms.PictureBox m_PublisherSmallPicture;
        private System.Windows.Forms.Button m_ExitButton;
        private System.Windows.Forms.Label m_LikesLabel;
        private System.Windows.Forms.Label m_CommeantsLable;
        private System.Windows.Forms.Label m_PostTypeLabel;
        private System.Windows.Forms.Label m_FullNameLabel;
        private System.Windows.Forms.Label m_PublishedDate;
        private System.Windows.Forms.Label m_LastModifiedDate;
        private System.Windows.Forms.RichTextBox m_MessageBox;
    }
}