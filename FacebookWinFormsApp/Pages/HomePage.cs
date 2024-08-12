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
    public partial class HomePage : UserControl
    {
        public event EventHandler RecivedInfo;
        public event EventHandler ChangePage;
        public string SelectedAppId { get; private set; }
        public override Color BackColor { get; set; }


        public HomePage()
        {
            InitializeComponent();
        }
    }
}
