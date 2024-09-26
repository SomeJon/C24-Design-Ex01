using FacebookPages.Code.Buttons;
using FacebookWrapper.ObjectModel;
using System;
using System.Windows.Forms;

namespace FacebookPages.Pages
{
    public partial class PhotosPage : BasePage
    {
        public FacebookObjectCollection<Album> PageData { get; set; }

        public PhotosPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            m_AlbumChoiceComboBox.DataSource = PageData;
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void loadAlbumIntoFlowLayoutPanel(Album iAlbum)
        {
            m_PicturesFlow.Controls.Clear();

            foreach (Photo photo in iAlbum.Photos)
            {
                LoadInfoPicture picBox = new LoadInfoPicture
                {
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Width = 150,
                    Height = 150,
                    Margin = new Padding(5)
                };

                picBox.LoadAsync(photo.PictureNormalURL);

                picBox.Click += OnRecivedInfo;

                m_PicturesFlow.Controls.Add(picBox);
            }
        }

        private void m_AlbumChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(sender != null)
            {
                loadAlbumIntoFlowLayoutPanel(((sender as ComboBox).SelectedItem as Album));
            }
            
        }
    }
}
