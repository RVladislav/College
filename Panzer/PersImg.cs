using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class PersImg
    {
        Image[] imgRight = new Image[] 
        {
            Properties.Resources.PRight__1_
                , Properties.Resources.PRight__1_
                , Properties.Resources.PRight__2_
                , Properties.Resources.PRight__2_
        };
        Image[] imgUp = new Image[]
        {
            Properties.Resources.PUp__1_
                , Properties.Resources.PUp__1_
                , Properties.Resources.PUp__2_
                , Properties.Resources.PUp__2_
        };
        Image[] imgLeft = new Image[]
        {
            Properties.Resources.PLeft__1_
                , Properties.Resources.PLeft__1_
                , Properties.Resources.PLeft__2_
                , Properties.Resources.PLeft__2_
        };
        Image[] imgDown = new Image[]
        {
            Properties.Resources.PDown__1_
                , Properties.Resources.PDown__1_
                , Properties.Resources.PDown__2_
                , Properties.Resources.PDown__2_
        };

        public Image[] ImgRight
        {
            get
            {
                return imgRight;
            }
        }
        public Image[] ImgUp
        {
            get
            {
                return imgUp;
            }
        }
        public Image[] ImgLeft
        {
            get
            {
                return imgLeft;
            }
        }
        public Image[] ImgDown
        {
            get
            {
                return imgDown;
            }
        }
    }
}
