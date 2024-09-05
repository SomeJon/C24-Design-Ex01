using FacebookPages.Code.Buttons;
using FacebookPages.Pages;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
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

        private void loadAlbumIntoFlowLayoutPanel(Album i_Album)
        {
            m_PicturesFlow.Controls.Clear();

            foreach (Photo photo in i_Album.Photos)
            {
                // Create a new PictureBox for each image
                LoadInfoPicture picBox = new LoadInfoPicture
                {
                    SizeMode = PictureBoxSizeMode.Zoom, // Use Zoom to maintain the aspect ratio
                    Width = 150, // Set width for PictureBox
                    Height = 150, // Set height for PictureBox
                    Margin = new Padding(5) // Add some margin around the PictureBox
                };

                picBox.LoadAsync(photo.PictureNormalURL); // Assign the image

                picBox.Click += OnRecivedInfo; //check it works

                // Add the PictureBox to the FlowLayoutPanel
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
