using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class WallImg
    {
        Image img = Properties.Resources.Wall;

        public Image Img
        {
            get
            {
                return img;
            }
            set
            {
                img = value;
            }
        }
    }
}
