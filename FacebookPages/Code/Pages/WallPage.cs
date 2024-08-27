using FacebookPages.Code.Buttons;
using FacebookPages.Pages.Data;
using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Pages
{
    public partial class WallPage : BasePage
    {
        public override Color BackColor { get; set; }
        public WallPageData Data { private get; set; }

        public WallPage()
        {
            InitializeComponent();
        }

        protected virtual void PageSwitchButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void WallPage_Load(object sender, EventArgs e)
        {
            if (Data?.ProfilePicUrl != null)
            {
                profilePicture.LoadAsync(Data.ProfilePicUrl);
            }

            if(Data?.CoverPicUrl != null)
            {
                coverPicture.LoadAsync(Data.CoverPicUrl);
                coverPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }


            m_ChooseFriend.DataSource = Data?.Friends;
            m_FillNumberOfFriends.Text = Data?.Friends.Count.ToString();
            m_PostViewButton.LoadInfoListBox.DataSource = Data?.Posts.Posts;

            textBoxFullName.Text = Data?.FirstName
                + " " + Data?.LastName;
        }

        private void m_ViewFriendButton_Click(object sender, EventArgs e)
        {
            (sender as HasDataInfo).RecivedInfo = m_ChooseFriend.RecivedInfo;
            (sender as HasDataInfo).InfoChoice = eInfoChoice.Friend;

            PageSwitchButton_Click(sender, e);
        }
    }
}
