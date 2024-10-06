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

        public PhotosPage()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs i_)
        {
            base.OnLoad(i_);

            new Thread(
                () =>
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
                            this.Invoke(new Action(() => m_AlbumChoiceComboBox.DataSource = PageData.Albums));
                        }
                    }).Start();
            
        }

        private void switchPageButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            ((IHasSwitchPage)i_Sender).NewPageOwner = PageData.PageUser;

            OnChangePage(i_Sender, i_EventArgs);
        }

        private void loadAlbumIntoFlowLayoutPanel(Album i_IAlbum)
        {
            m_PicturesFlow.Controls.Clear();

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

        private void m_AlbumChoiceComboBox_SelectedIndexChanged(object i_Sender, EventArgs i_EventArgs)
        {
            if(i_Sender != null)
            {
                loadAlbumIntoFlowLayoutPanel((((ComboBox)i_Sender).SelectedItem as Album));
            }
        }
    }
}
