using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Pages
{
    public partial class LoginPage : BasePage
    {
        private Timer m_RotationTimer;
        private int m_RotationAngle = 0;
        private Image m_OriginalImage;

        public override Color BackColor {  get; set; }

        public LoginPage()
        {
            InitializeComponent();
            m_OriginalImage = facebooklogo.Image;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitConfirmationForm exitForm = new ExitConfirmationForm();
            exitForm.ShowDialog();
        }

        private void facebooklogo_Click(object sender, EventArgs e)
        {
            m_RotationAngle = 0;
            m_RotationTimer.Start();
        }

    }
}
