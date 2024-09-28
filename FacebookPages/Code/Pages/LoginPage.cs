using System;
using System.Drawing;
using System.Windows.Forms;

namespace FacebookPages.Code.Pages
{
    public partial class LoginPage : BasePage
    {
        private Timer m_RotationTimer;
        private int m_RotationAngle = 0;
        private Image m_OriginalImage;
        public event EventHandler RemeberLogin;
        public override Color BackColor { get; set; }

        public LoginPage()
        {
            InitializeComponent();
            m_RotationTimer = new Timer();
            m_RotationTimer.Interval = 10;
            m_RotationTimer.Tick += RotationTimer_Tick;
            m_OriginalImage = facebooklogo.Image;
        }

        private void LoginPage_Load(object i_Sender, EventArgs i_EventArgs)
        {
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void switchPageButton_Click(object i_Sender, EventArgs i_EventArgs)
        {
            OnChangePage(i_Sender, i_EventArgs);
        }

        private void facebookLogo_Click(object i_Sender, EventArgs i_EventArgs)
        {
            m_RotationAngle = 0;
            m_RotationTimer.Start();
        }

        private void RotationTimer_Tick(object i_Sender, EventArgs i_EventArgs)
        {
            m_RotationAngle += 10;
            Bitmap rotatedImage = new Bitmap(m_OriginalImage.Width, m_OriginalImage.Height);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                g.TranslateTransform((float)m_OriginalImage.Width / 2, (float)m_OriginalImage.Height / 2);
                g.RotateTransform(m_RotationAngle);
                g.TranslateTransform(-(float)m_OriginalImage.Width / 2, -(float)m_OriginalImage.Height / 2);
                g.DrawImage(m_OriginalImage, new Point(0, 0));
            }

            facebooklogo.Image = rotatedImage;
            facebooklogo.Refresh();
            if (m_RotationAngle >= 360)
            {
                m_RotationTimer.Stop();
                m_RotationAngle = 0;
                facebooklogo.Image = m_OriginalImage;
            }
        }

        private void rememberLoginCheckBox_Click(object i_Sender, EventArgs i_EventArgs)
        {
            RemeberLogin?.Invoke(i_Sender, i_EventArgs);
        }
    }
}
