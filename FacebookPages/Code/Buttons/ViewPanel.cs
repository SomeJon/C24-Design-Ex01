using FacebookPages.Pages;
using System.Windows.Forms;
using FacebookPages.Code.Pages;

namespace FacebookPages.Code.Buttons
{
    public class ViewPanel : Panel
    {
        private BasePage m_CurrentActivePage = new BasePage();

        public BasePage CurrentActivePage 
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

                // Add the new page and dock it to fill the panel
                if (m_CurrentActivePage != null)
                {
                    m_CurrentActivePage.Dock = DockStyle.Fill;
                    this.Controls.Add(m_CurrentActivePage);
                }
            } 
        }
    }
}
