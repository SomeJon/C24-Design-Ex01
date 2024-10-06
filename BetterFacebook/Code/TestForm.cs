using FacebookPages.Code.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacebookClient.Code
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();

            UserControl currentActivePage = new UserControl();
            currentActivePage = new UserControl1();

            currentActivePage.Dock = DockStyle.Fill;

            panel1.Controls.Add(currentActivePage);
        }
    }
}
