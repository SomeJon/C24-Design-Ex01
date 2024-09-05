using FacebookPages.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookPages.Code.Buttons
{
    public class ViewPanel : Panel
    {
        private BasePage m_CurrentActivePage = new BasePage();

        public BasePage CurrentActivePage 
        { 
            get
            {
               return m_CurrentActivePage;
            }
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
