using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class Pers : IRun, ITurn, ITransparent, ICurrentPic
    {
        int x, y, direct_x, direct_y, nextDirect_x, nextDirect_y;
        int sizeField;

        Image[] img;
        Image currentImg;

        PersImg persImg = new PersImg();

        public Pers(int sizeField)
        {
            this.sizeField = sizeField;
            img = persImg.ImgRight;

            this.x = 120;
            this.y = 240;

            Direct_x = 0;
            Direct_y = -1;

            nextDirect_x = 0;
            nextDirect_y = -1;
            
            PutImg();
            PutCurrentImg();
        }

        public void Run()
        {

            x += Direct_x;
            y += Direct_y;

            if (Math.IEEERemainder(x, 40) == 0 && Math.IEEERemainder(y, 40) == 0)
            {
                Turn();
            }
            PutCurrentImg();
            Transparent();
        }

        int k;
        private void PutCurrentImg()
        {
            currentImg = img[k];
            k++;
            if (k == 4) k = 0;
        }  

        public Image CurrentImg
        {
            get { return currentImg; }
        }
        public Image[] Img
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
            get { return y; }
        }

        public int Direct_x
        {
            get { return direct_x; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                {
                    direct_x = value;
                }
                else
                {
                    direct_x = 0;
                }
            }
        }

        public int Direct_y
        {
            get { return direct_y; }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                {
                    direct_y = value;
                }
                else
                {
                    direct_y = 0;
                }
            }
        }

        public int NextDirect_x
        {
            get
            {
                return nextDirect_x;
            }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_x = value;
                else
                    nextDirect_x = 0;
            }
        }

        public int NextDirect_y
        {
            get
            {
                return nextDirect_y;
            }
            set
            {
                if (value == 0 || value == 1 || value == -1)
                    nextDirect_y = value;
                else
                    nextDirect_y = 0;
            }
        }

        public void Turn()
        {
            Direct_x = NextDirect_x;
            Direct_y = NextDirect_y;
            PutImg();
        }

        public void Transparent()
        {
            //if (x + 20 < 0) x = sizeField;//Left
            //if (x > sizeField) x = -19;//Right
            //if (y + 20 < 0) y = 300;//Top
            //if (y > 300) y = -19;//Bottom
            //// 300 - Bottom's border
            if (x == -1)
                x = sizeField - 21;
            if (x == sizeField - 19)
                x = 1;
            if (y == -1)
                y = 300 - 21;
            if (y == 300 - 19)
                y = 1;
            
        }

        public void PutImg()
        {
            if (Direct_x == 1) img = persImg.ImgRight;
            if (Direct_x == -1) img = persImg.ImgLeft;
            if (Direct_y == 1) img = persImg.ImgDown;
            if (Direct_y == -1) img = persImg.ImgUp;
        }
    }
}
