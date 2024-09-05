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

        private void LoginPage_Load(object sender, EventArgs e)
        {
            dateLabel.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void switchPageButton_Click(object sender, EventArgs e)
        {
            OnChangePage(sender, e);
        }

        private void facebooklogo_Click(object sender, EventArgs e)
        {
            m_RotationAngle = 0;
            m_RotationTimer.Start();
        }

        private void RotationTimer_Tick(object sender, EventArgs e)
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

        private void rememberLoginChackBox_Click(object sender, EventArgs e)
        {
            RemeberLogin?.Invoke(sender, new EventArgs());
        }
    }
}
