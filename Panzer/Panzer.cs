using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class Panzer : IRun
    {
        int x, y;

        Image img;
        PanzerIMG panzerImg = new PanzerIMG();

        public Panzer()
        {
            img = panzerImg.Img;
        }

        public Image Img
        {
            get
            {
                return img;
            }
        }

        public int X
        {
            get
            {
                return x;
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
        }

        public void Run()
        {
            x = ++y;
        }
    }
}
