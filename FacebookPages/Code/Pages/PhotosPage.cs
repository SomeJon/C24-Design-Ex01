using System;
using System.Threading;
using System.Windows.Forms;
using FacebookPages.Code.Buttons;
using FacebookPages.Code.Pages.Data;
using FacebookPages.Code.Pages.Factory.Interfaces;
using FacebookWrapper.ObjectModel;

namespace FacebookPages.Code.Pages
{
    public partial class PhotosPage : Page
    {
        internal PhotoPageData PageData { private get; set; }

        internal PhotosPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs i_)
        {
            base.OnLoad(i_);

            new Thread(loadDataInBackground).Start();
            
        }

        private void loadDataInBackground()
        {
            try
            {
                PageData.LoadAllCurrentData();
            }
            catch(System.InvalidOperationException invalidOperation)
            {
                MessageBox.Show(invalidOperation.Message, @"Error");
            }
            finally
            {
                this.Invoke(new Action(() =>
                    {
                        albumsBindingSource.DataSource = PageData;
                        if (m_AlbumChoiceComboBox?.SelectedItem is Album toSend)
                        {
                            loadAlbumIntoFlowLayoutPanel(toSend);
                        }
                    }));
            }
        }

        private void switchPageButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;

            OnChangePage(i_Sender, i_EventArgs);
        }

        private void loadAlbumIntoFlowLayoutPanel(Album i_Album)
        {
            m_PicturesFlow.Controls.Clear();

            new Thread(() => loadAlbumInBackground(i_Album)).Start();
        }

        private void loadAlbumInBackground(Album i_Album)
        {
            foreach (Photo photo in i_Album.Photos)
            {
                LoadInfoPicture picBox = new LoadInfoPicture
                                             {
                                                 SizeMode = PictureBoxSizeMode.Zoom,
                                                 Width = 150,
                                                 Height = 150,
                                                 Margin = new Padding(5)
                                             };

                picBox.InfoChoice = eInfoChoice.Picture;
                picBox.DoubleClick += OnReceivedInfo;

                this.Invoke(new Action(() =>
                    {
                        picBox.LoadAsync(photo.PictureNormalURL);
                        m_PicturesFlow.Controls.Add(picBox);
                    }));
            }
        }

        private void m_AlbumChoiceComboBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if(((ComboBox)i_Sender)?.SelectedItem is Album toSend)
            {
                loadAlbumIntoFlowLayoutPanel(toSend);
            }
        }

        private void imageAlbumPictureBox_DoubleClick(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasDataInfo)i_Sender).ReceivedInfo = (i_Sender as LoadInfoPicture).Image;
            OnReceivedInfo(i_Sender, i_EventArgs);
        }
    }
}
