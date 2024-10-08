using System.Windows.Forms;
using FacebookPages.Code.Pages;
using System;

namespace FacebookPages.Code.Buttons
{
    public class ViewPanel : Panel
    {
        private Page m_CurrentActivePage = new Page();
        public event EventHandler ReceivedInfo;
        public event EventHandler ChangePage;
        public Page CurrentActivePage 
        { 
            get => m_CurrentActivePage;
            set 
            {
                // If the current page is set, remove it from the panel
                if (m_CurrentActivePage != null)
                {
                    this.Controls.Remove(m_CurrentActivePage);
                }

                // Set the new page
                m_CurrentActivePage = value;
                //m_CurrentActivePage = new UserControl1();

                // Add the new page and dock it to fill the panel
                if (m_CurrentActivePage != null)
                {
                    m_CurrentActivePage.ReceivedInfo += ReceivedInfo;
                    m_CurrentActivePage.ChangePage += ChangePage;
                    m_CurrentActivePage.Dock = DockStyle.Fill;
                    this.Controls.Add(m_CurrentActivePage);
                }
            } 
        }
    }
}
