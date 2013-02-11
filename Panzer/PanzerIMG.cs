using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class PanzerIMG
    {
        Image imgRight = Properties.Resources.PanzerRight1;
        Image imgUp = Properties.Resources.PanzerUp1;
        Image imgLeft = Properties.Resources.PanzerLeft1;
        Image imgDown = Properties.Resources.PanzerDown1;

        public Image ImgRight
        {
            get
            {
                return imgRight;
            }
            set
            {
                imgRight = value;
            }
        }
        public Image ImgUp
        {
            get
            {
                return imgUp;
            }
            set
            {
                imgUp = value;
            }
        }
        public Image ImgLeft
        {
            get
            {
                return imgLeft;
            }
            set
            {
                imgLeft = value;
            }
        }
        public Image ImgDown
        {
            get
            {
                return imgDown;
            }
            set
            {
                imgDown = value;
            }
        }
    }
}
