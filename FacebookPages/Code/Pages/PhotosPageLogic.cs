using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookPages.Code.Buttons;
using FacebookWrapper.ObjectModel;


namespace FacebookPages.Code.Pages
{
    public class PhotosPageLogic
    {
        private void loadAlbumIntoFlowLayoutPanel(Album i_IAlbum)
        {
            Controls.Clear();

            foreach (Photo photo in i_IAlbum.Photos)
            {
                LoadInfoPicture picBox = new LoadInfoPicture
                                             {
                                                 SizeMode = PictureBoxSizeMode.Zoom,
                                                 Width = 150,
                                                 Height = 150,
                                                 Margin = new Padding(5)
                                             };

                picBox.LoadAsync(photo.PictureNormalURL);

                picBox.Click += OnReceivedInfo;

                m_PicturesFlow.Controls.Add(picBox);
            }
        }

    }
}
