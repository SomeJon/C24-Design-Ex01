using FacebookPages.Pages.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            textBoxFullName.Text = Data?.FirstName
                + " " + Data?.LastName;
        }
    }
}
