using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class Stars : IPic
    {
        StarImg starImg = new StarImg();
        Image img;

        int x, y;

        public int X 
        {
            get {return x;}
        }

        public int Y
        {
            get {return y;}
        }

        public Stars(int x, int y)
        {
            this.x = x;
            this.y = y;
            img = starImg.Img;
        }

        public Image Img
        {
            get
            {
                return img;
            }

        }
    }
}
