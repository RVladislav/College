using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class PanzerIMG
    {
        Image img = Properties.Resources.TankEnemy;

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
