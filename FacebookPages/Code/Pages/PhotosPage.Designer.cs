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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_PicturesFlow = new System.Windows.Forms.FlowLayoutPanel();
            this.imageAlbumPictureBox = new System.Windows.Forms.PictureBox();
            this.nameLabel1 = new System.Windows.Forms.Label();
            this.createdTimeLabel1 = new System.Windows.Forms.Label();
            this.countLabel1 = new System.Windows.Forms.Label();
            this.photoPageDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.albumsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            nameLabel = new System.Windows.Forms.Label();
            createdTimeLabel = new System.Windows.Forms.Label();
            countLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPageDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            nameLabel.Location = new System.Drawing.Point(469, 49);
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
            createdTimeLabel.Location = new System.Drawing.Point(412, 113);
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
            countLabel.Location = new System.Drawing.Point(468, 81);
            countLabel.Name = "countLabel";
            countLabel.Size = new System.Drawing.Size(58, 18);
            countLabel.TabIndex = 85;
            countLabel.Text = "Count:";
            // 
            // buttonReturn
            // 
            this.buttonReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturn.Location = new System.Drawing.Point(5, 5);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(5);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.NewPageOwner = null;
            this.buttonReturn.PageChoice = FacebookPages.Code.Pages.Factory.Interfaces.ePageChoice.WallPage;
            this.buttonReturn.Size = new System.Drawing.Size(93, 47);
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
            this.label1.Location = new System.Drawing.Point(117, 7);
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
            this.m_AlbumChoiceComboBox.Location = new System.Drawing.Point(381, 18);
            this.m_AlbumChoiceComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.m_AlbumChoiceComboBox.Name = "m_AlbumChoiceComboBox";
            this.m_AlbumChoiceComboBox.Size = new System.Drawing.Size(564, 24);
            this.m_AlbumChoiceComboBox.TabIndex = 80;
            this.m_AlbumChoiceComboBox.ValueMember = "Comments";
            this.m_AlbumChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.m_AlbumChoiceComboBox_SelectedIndexChanged);
            // 
            // m_PicturesFlow
            // 
            this.m_PicturesFlow.AutoScroll = true;
            this.m_PicturesFlow.BackColor = System.Drawing.Color.SteelBlue;
            this.m_PicturesFlow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_PicturesFlow.Location = new System.Drawing.Point(0, 150);
            this.m_PicturesFlow.Margin = new System.Windows.Forms.Padding(4);
            this.m_PicturesFlow.Name = "m_PicturesFlow";
            this.m_PicturesFlow.Size = new System.Drawing.Size(949, 370);
            this.m_PicturesFlow.TabIndex = 82;
            // 
            // imageAlbumPictureBox
            // 
            this.imageAlbumPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.imageAlbumPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.albumsBindingSource, "ImageThumb", true));
            this.imageAlbumPictureBox.Location = new System.Drawing.Point(830, 49);
            this.imageAlbumPictureBox.Name = "imageAlbumPictureBox";
            this.imageAlbumPictureBox.Size = new System.Drawing.Size(115, 86);
            this.imageAlbumPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imageAlbumPictureBox.TabIndex = 83;
            this.imageAlbumPictureBox.TabStop = false;
            // 
            // nameLabel1
            // 
            this.nameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Name", true));
            this.nameLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameLabel1.Location = new System.Drawing.Point(555, 50);
            this.nameLabel1.Name = "nameLabel1";
            this.nameLabel1.Size = new System.Drawing.Size(100, 23);
            this.nameLabel1.TabIndex = 84;
            this.nameLabel1.Text = "label2";
            // 
            // createdTimeLabel1
            // 
            this.createdTimeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "CreatedTime", true));
            this.createdTimeLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createdTimeLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.createdTimeLabel1.Location = new System.Drawing.Point(555, 112);
            this.createdTimeLabel1.Name = "createdTimeLabel1";
            this.createdTimeLabel1.Size = new System.Drawing.Size(100, 23);
            this.createdTimeLabel1.TabIndex = 85;
            this.createdTimeLabel1.Text = "label2";
            // 
            // countLabel1
            // 
            this.countLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.albumsBindingSource, "Count", true));
            this.countLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.countLabel1.Location = new System.Drawing.Point(555, 79);
            this.countLabel1.Name = "countLabel1";
            this.countLabel1.Size = new System.Drawing.Size(100, 23);
            this.countLabel1.TabIndex = 86;
            this.countLabel1.Text = "label2";
            // 
            // photoPageDataBindingSource
            // 
            this.photoPageDataBindingSource.DataSource = typeof(FacebookPages.Code.Pages.Data.PhotoPageData);
            // 
            // albumsBindingSource
            // 
            this.albumsBindingSource.DataMember = "Albums";
            this.albumsBindingSource.DataSource = this.photoPageDataBindingSource;
            // 
            // PhotosPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PhotosPage";
            this.Size = new System.Drawing.Size(949, 520);
            ((System.ComponentModel.ISupportInitialize)(this.imageAlbumPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoPageDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private PageSwitchButton buttonReturn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox m_AlbumChoiceComboBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.FlowLayoutPanel m_PicturesFlow;
        private System.Windows.Forms.PictureBox imageAlbumPictureBox;
        private System.Windows.Forms.Label nameLabel1;
        private System.Windows.Forms.Label createdTimeLabel1;
        private System.Windows.Forms.Label countLabel1;
        private System.Windows.Forms.BindingSource albumsBindingSource;
        private System.Windows.Forms.BindingSource photoPageDataBindingSource;
    }
}
