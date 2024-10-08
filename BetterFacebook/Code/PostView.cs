using System;
using System.Windows.Forms;
using FacebookWrapperEnhancements.Code.EnhancedObjects;

namespace FacebookClient.Code
{
    public partial class PostView : Form
    {
        public PostView(EnhancedPost i_PostData)
        {
            InitializeComponent();

            enhancedPostBindingSource.DataSource = i_PostData;
        }


        private void m_ExitButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            this.Close();
        }
    }
}
