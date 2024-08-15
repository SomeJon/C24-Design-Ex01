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
    public partial class HomePage : BasePage
    {
        public string SelectedAppId { get; private set; }
        public override Color BackColor { get; set; }
        public HomePageData Data { private get; set; }

        public HomePage()
        {
            InitializeComponent();
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            if (Data?.ProfilePicUrl != null)
            {
                profilePicture.LoadAsync(Data.ProfilePicUrl);

            }

            textBoxFullName.Text = Data?.FirstName
                + " " + Data?.LastName;
        }


    }
}
