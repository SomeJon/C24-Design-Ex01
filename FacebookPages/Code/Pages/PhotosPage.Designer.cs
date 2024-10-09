using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Factory.Interfaces;

namespace FacebookPages.Code.Pages
{
    partial class PhotosPage
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
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label createdTimeLabel;
            System.Windows.Forms.Label countLabel;
            this.buttonReturn = new FacebookPages.Code.Buttons.PageSwitchButton();
            this.label1 = new System.Windows.Forms.Label();
            this.m_AlbumChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.photoPageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_PicturesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.imageAlbumPictureBox = new FacebookPages.Code.Buttons.LoadInfoPicture();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(352, 40);
            nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(57, 18);
            nameLabel.TabIndex = 83;
            nameLabel.Text = "Name:";
            // 
            // createdTimeLabel
            // 
            createdTimeLabel.AutoSize = true;
            createdTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            createdTimeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            createdTimeLabel.Location = new System.Drawing.Point(295, 92);
            createdTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            createdTimeLabel.Name = "createdTimeLabel";
            createdTimeLabel.Size = new System.Drawing.Size(114, 18);
            createdTimeLabel.TabIndex = 84;
            createdTimeLabel.Text = "Created Time:";
            // 
            // countLabel
            // 
            countLabel.AutoSize = true;
            countLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            countLabel.Location = new System.Drawing.Point(351, 66);
            countLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(58, 18);
            countLabel.TabIndex = 85;
            countLabel.Text = "Count:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(4, 4);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.NewPageOwner = null;
            this.buttonReturn.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.WallPage;
            this.buttonReturn.Size = new System.Drawing.Size(70, 38);
            this.buttonReturn.TabIndex = 76;
            this.buttonReturn.Text = "Return";
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.switchPageButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(88, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 36);
            this.label1.TabIndex = 79;
            this.label1.Text = "my albums:";
            // 
            // m_AlbumChoiceComboBox
            // 
            this.m_AlbumChoiceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_AlbumChoiceComboBox.DataSource = this.albumsBindingSource;
            this.m_AlbumChoiceComboBox.DisplayMember = "Name";
            this.m_AlbumChoiceComboBox.FormattingEnabled = true;
            this.m_AlbumChoiceComboBox.Location = new System.Drawing.Point(286, 15);
            this.m_AlbumChoiceComboBox.Name = "m_AlbumChoiceComboBox";
            this.m_AlbumChoiceComboBox.Size = new System.Drawing.Size(424, 21);
            this.m_AlbumChoiceComboBox.TabIndex = 80;
            this.m_AlbumChoiceComboBox.ValueMember = "Comments";
            this.m_AlbumChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.m_AlbumChoiceComboBox_SelectedIndexChanged);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.photoPageDataBindingSource;
            // 
            // photoPageDataBindingSource
            // 
            this.photoPageDataBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.PhotoPageData);
            // 
            // m_PicturesFlow
            // 
            this.m_PicturesFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.m_PicturesFlow.AutoScroll = true;
            this.m_PicturesFlow.BackColor = System.Drawing.Color.SteelBlue;
            this.m_PicturesFlow.Location = new System.Drawing.Point(0, 121);
            this.m_PicturesFlow.Name = "m_PicturesFlow";
            this.m_PicturesFlow.Size = new System.Drawing.Size(712, 301);
            this.m_PicturesFlow.TabIndex = 82;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "ImageAlbum", true));
            this.imageAlbumPictureBox.InfoChoice = FacebookPages.Code.Pages.Factory.Interfaces.eInfoChoice.Picture;
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(622, 40);
            this.imageAlbumPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.ReceivedInfo = null;
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(86, 70);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageAlbumPictureBox.TabIndex = 83;
            this.imageAlbumPictureBox.TabStop = false;
            this.imageAlbumPictureBox.DoubleClick += new System.EventHandler(this.imageAlbumPictureBox_DoubleClick);
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel1.Location = new System.Drawing.Point(416, 41);
            this.nameLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(75, 19);
            this.nameLabel1.TabIndex = 84;
            this.nameLabel1.Text = "label2";
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createdTimeLabel1.Location = new System.Drawing.Point(416, 91);
            this.createdTimeLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(75, 19);
            this.createdTimeLabel1.TabIndex = 85;
            this.createdTimeLabel1.Text = "label2";
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Count", true));
            this.countLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countLabel1.Location = new System.Drawing.Point(416, 64);
            this.countLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(75, 19);
            this.countLabel1.TabIndex = 86;
            this.countLabel1.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(3, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 87;
            this.label2.Text = "Double click on an image to view bigger";
            // 
            // PhotosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.Controls.Add(this.label2);
            this.Controls.Add(countLabel);
            this.Controls.Add(this.countLabel1);
            this.Controls.Add(createdTimeLabel);
            this.Controls.Add(this.createdTimeLabel1);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameLabel1);
            this.Controls.Add(this.imageAlbumPictureBox);
            this.Controls.Add(this.m_PicturesFlow);
            this.Controls.Add(this.m_AlbumChoiceComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonReturn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PhotosPage";
            this.Size = new System.Drawing.Size(712, 422);
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_AlbumChoiceComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel m_PicturesFlow;
        private LoadInfoPicture imageAlbumPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource photoPageDataBindingSource;
        private System.Windows.Forms.Label label2;
    }
}
