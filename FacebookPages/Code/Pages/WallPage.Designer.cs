﻿using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Pages
{
    partial class WallPage
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
            this.m_ExitButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.aboutButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.pictureButton = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.wallPageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.coverPicture = new System.Windows.Forms.PictureBox();
            this.m_PostViewButton = new FacebookPages.Code.Buttons.PostViewButton();
            this.m_NumberOfFriendsLabel = new System.Windows.Forms.Label();
            this.m_FillNumberOfFriends = new System.Windows.Forms.Label();
            this.m_ChooseFriend = new FacebookPages.Code.Buttons.LoadInfoComboBox();
            this.friendsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.m_ViewFriendButton = new FacebookPages.Code.Buttons.PageSwitchAndLoadButton();
            ((System.ComponentModel.ISupportInitialize)(this.wallPageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // m_ExitButton
            // 
            this.m_ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_ExitButton.Location = new System.Drawing.Point(3, 3);
            this.m_ExitButton.Name = "m_ExitButton";
            this.m_ExitButton.NewPageOwner = null;
            this.m_ExitButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.HomePage;
            this.m_ExitButton.Size = new System.Drawing.Size(96, 42);
            this.m_ExitButton.TabIndex = 67;
            this.m_ExitButton.Text = "Back";
            this.m_ExitButton.UseVisualStyleBackColor = true;
            this.m_ExitButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.aboutButton.Location = new System.Drawing.Point(238, 150);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.NewPageOwner = null;
            this.aboutButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.AboutMePage;
            this.aboutButton.Size = new System.Drawing.Size(133, 30);
            this.aboutButton.TabIndex = 63;
            this.aboutButton.Text = "About ME";
            this.aboutButton.UseVisualStyleBackColor = true;
            this.aboutButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // pictureButton
            // 
            this.pictureButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.pictureButton.Location = new System.Drawing.Point(239, 182);
            this.pictureButton.Name = "pictureButton";
            this.pictureButton.NewPageOwner = null;
            this.pictureButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.PicturePage;
            this.pictureButton.Size = new System.Drawing.Size(132, 30);
            this.pictureButton.TabIndex = 62;
            this.pictureButton.Text = "Pictures";
            this.pictureButton.UseVisualStyleBackColor = true;
            this.pictureButton.Click += new System.EventHandler(this.PageSwitchButton_Click);
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.DarkBlue;
            this.textBoxFullName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.wallPageDataBindingSource, "FullName", true));
            this.textBoxFullName.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFullName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxFullName.Location = new System.Drawing.Point(236, 106);
            this.textBoxFullName.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFullName.Multiline = true;
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(317, 44);
            this.textBoxFullName.TabIndex = 67;
            this.textBoxFullName.Text = "FULL NAME";
            this.textBoxFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // wallPageDataBindingSource
            // 
            this.wallPageDataBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.WallPageData);
            // 
            // profilePicture
            // 
            this.profilePicture.BackColor = System.Drawing.Color.MediumBlue;
            this.profilePicture.Location = new System.Drawing.Point(0, 106);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(234, 182);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 68;
            this.profilePicture.TabStop = false;
            // 
            // coverPicture
            // 
            this.coverPicture.BackColor = System.Drawing.Color.Navy;
            this.coverPicture.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverPicture.Location = new System.Drawing.Point(0, 0);
            this.coverPicture.Name = "coverPicture";
            this.coverPicture.Size = new System.Drawing.Size(674, 106);
            this.coverPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPicture.TabIndex = 69;
            this.coverPicture.TabStop = false;
            // 
            // m_PostViewButton
            // 
            this.m_PostViewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PostViewButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_PostViewButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.m_PostViewButton.Location = new System.Drawing.Point(0, 285);
            this.m_PostViewButton.Margin = new System.Windows.Forms.Padding(4);
            this.m_PostViewButton.Name = "m_PostViewButton";
            this.m_PostViewButton.Size = new System.Drawing.Size(674, 127);
            this.m_PostViewButton.TabIndex = 73;
            this.m_PostViewButton.MorePostsRequest += new System.EventHandler(this.m_PostViewButton_MorePostsRequest);
            this.m_PostViewButton.ChangeConnectionRequest += new System.EventHandler(this.m_PostViewButton_ChangeConnectionRequest);
            this.m_PostViewButton.PostSelected += new System.EventHandler(this.m_PostViewButton_PostSelected);
            this.m_PostViewButton.FilterRequest += new System.EventHandler(this.m_PostViewButton_FilterRequest);
            this.m_PostViewButton.LoadAllPosts += new System.EventHandler(this.m_PostViewButton_LoadAllPosts);
            this.m_PostViewButton.PostAnalyticRequest += new System.EventHandler(this.m_PostViewButton_PostAnalyticRequest);
            // 
            // m_NumberOfFriendsLabel
            // 
            this.m_NumberOfFriendsLabel.AutoSize = true;
            this.m_NumberOfFriendsLabel.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.m_NumberOfFriendsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_NumberOfFriendsLabel.Location = new System.Drawing.Point(417, 153);
            this.m_NumberOfFriendsLabel.Name = "m_NumberOfFriendsLabel";
            this.m_NumberOfFriendsLabel.Size = new System.Drawing.Size(73, 25);
            this.m_NumberOfFriendsLabel.TabIndex = 75;
            this.m_NumberOfFriendsLabel.Text = "Friends:";
            // 
            // m_FillNumberOfFriends
            // 
            this.m_FillNumberOfFriends.AutoSize = true;
            this.m_FillNumberOfFriends.Font = new System.Drawing.Font("Segoe UI", 12.8F);
            this.m_FillNumberOfFriends.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_FillNumberOfFriends.Location = new System.Drawing.Point(478, 153);
            this.m_FillNumberOfFriends.Name = "m_FillNumberOfFriends";
            this.m_FillNumberOfFriends.Size = new System.Drawing.Size(22, 25);
            this.m_FillNumberOfFriends.TabIndex = 76;
            this.m_FillNumberOfFriends.Text = "0";
            // 
            // m_ChooseFriend
            // 
            this.m_ChooseFriend.DataSource = this.friendsBindingSource;
            this.m_ChooseFriend.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_ChooseFriend.FormattingEnabled = true;
            this.m_ChooseFriend.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.Friend;
            this.m_ChooseFriend.ItemHeight = 18;
            this.m_ChooseFriend.Location = new System.Drawing.Point(422, 190);
            this.m_ChooseFriend.Name = "m_ChooseFriend";
            this.m_ChooseFriend.ReceivedInfo = null;
            this.m_ChooseFriend.Size = new System.Drawing.Size(153, 26);
            this.m_ChooseFriend.TabIndex = 77;
            // 
            // friendsBindingSource
            // 
            this.friendsBindingSource.DataMember = "Friends";
            this.friendsBindingSource.DataSource = this.wallPageDataBindingSource;
            // 
            // m_ViewFriendButton
            // 
            this.m_ViewFriendButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.m_ViewFriendButton.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.Friend;
            this.m_ViewFriendButton.Location = new System.Drawing.Point(422, 218);
            this.m_ViewFriendButton.Name = "m_ViewFriendButton";
            this.m_ViewFriendButton.NewPageOwner = null;
            this.m_ViewFriendButton.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.FriendPage;
            this.m_ViewFriendButton.ReceivedInfo = null;
            this.m_ViewFriendButton.Size = new System.Drawing.Size(153, 28);
            this.m_ViewFriendButton.TabIndex = 78;
            this.m_ViewFriendButton.Text = "View Selected Friend";
            this.m_ViewFriendButton.UseVisualStyleBackColor = true;
            this.m_ViewFriendButton.Click += new System.EventHandler(this.m_ViewFriendButton_Click);
            // 
            // WallPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.m_ViewFriendButton);
            this.Controls.Add(this.m_ChooseFriend);
            this.Controls.Add(this.m_FillNumberOfFriends);
            this.Controls.Add(this.m_NumberOfFriendsLabel);
            this.Controls.Add(this.m_PostViewButton);
            this.Controls.Add(this.m_ExitButton);
            this.Controls.Add(this.coverPicture);
            this.Controls.Add(this.profilePicture);
            this.Controls.Add(this.textBoxFullName);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.pictureButton);
            this.Name = "WallPage";
            this.Size = new System.Drawing.Size(674, 412);
            ((System.ComponentModel.ISupportInitialize)(this.wallPageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coverPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.friendsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PageSwitchButton pictureButton;
        private PageSwitchButton aboutButton;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.PictureBox coverPicture;
        private Code.Buttons.PostViewButton m_PostViewButton;
        protected PageSwitchButton m_ExitButton;
        private System.Windows.Forms.Label m_NumberOfFriendsLabel;
        private System.Windows.Forms.Label m_FillNumberOfFriends;
        protected LoadInfoComboBox m_ChooseFriend;
        private PageSwitchAndLoadButton m_ViewFriendButton;
        private System.Windows.Forms.BindingSource wallPageDataBindingSource;
        private System.Windows.Forms.BindingSource friendsBindingSource;
    }
}
