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
    public partial class ImageForm : Form
    {
        public Image Image
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        public ImageForm()
        {
            InitializeComponent();
        }
    }
}
