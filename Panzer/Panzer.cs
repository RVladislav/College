using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading;

namespace Panzer
{
    class Panzer : IRun, ITurn, ITransparent, ICurrentPic, ITurnArround
    {
        int x, y, direct_x, direct_y;
        int sizeField;

        Image[] img;
        Image currentImg;

        PanzerImg panzerImg = new PanzerImg();
        static Random R;        

        public Panzer(int sizeField, int x, int y)
        {
            this.sizeField = sizeField;
            img = panzerImg.ImgRight;
            R = new Random();
            this.x = x;
            this.y = y;

            Direct_x = R.Next(-1,2);
            if (Direct_x == 0)
            {
                Direct_y = 0;
                while(Direct_y==0)
                    Direct_y = R.Next(-1, 2);
            }
            else
                Direct_y = 0;
            PutImg();
            PutCurrentImg();
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

        public void Turn()
        {

            if (R.Next(50) < 25)//Horizontal
            {
                if (Direct_x == 0)
                {
                    Direct_y = 0;
                    while (Direct_x == 0)
                    {
                        Direct_x = R.Next(-1, 2);
                    }
                }
            }
            else//Vertical
            {
                if (R.Next(50) < 25)//Horizontal
                {
                    if (Direct_y == 0)
                    {
                        Direct_x = 0;
                        while (Direct_y == 0)
                        {
                            Direct_y = R.Next(-1, 2);
                        }
                    }
                }
            }
            PutImg();
            

        }

       

        public void Transparent()
        {
            if (x + 20 < 0) x = sizeField;//Left
            if (x > sizeField) x = -19;//Right
            if (y + 20 < 0) y = 300;//Top
            if (y > 300) y = -19;//Bottom
            // 300 - Bottom's border
        }

        public void PutImg()
        {
            if (Direct_x == 1) img = panzerImg.ImgRight;
            if (Direct_x == -1) img = panzerImg.ImgLeft;
            if (Direct_y == 1) img = panzerImg.ImgDown;
            if (Direct_y == -1) img = panzerImg.ImgUp;
        }

        public void TurnAround()
        {
            Direct_x = -1 * Direct_x;
            Direct_y = -1 * Direct_y;
            PutImg();
        }
    }
}
