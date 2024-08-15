using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacebookPages.Pages.Data
{
    public class Theme
    {
        public Font TextFont { get; set; }
        public Font HeaderFont { get; set; }
        public Color BackGroundColor { get; set; }
        public Color BoxesColor { get; set; }

        public Theme(Font i_TextFont, Font i_HeaaderFont, 
            Color i_BackGroundColor, Color i_BoxesColor) 
        {
            TextFont = i_TextFont;
            HeaderFont = i_HeaaderFont;
            BackGroundColor = i_BackGroundColor;
            BoxesColor = i_BoxesColor;
        }
    }
}
