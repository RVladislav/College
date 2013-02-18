using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class HunterImg
    {
        Image[] imgRight = new Image[] 
        {
            Properties.Resources.HunterRight__1_
                , Properties.Resources.HunterRight__1_
                , Properties.Resources.HunterRight__2_
                , Properties.Resources.HunterRight__2_
        };
        Image[] imgUp = new Image[]
        {
            Properties.Resources.HunterUp__1_
                , Properties.Resources.HunterUp__1_
                , Properties.Resources.HunterUp__2_
                , Properties.Resources.HunterUp__2_
        };
        Image[] imgLeft = new Image[]
        {
            Properties.Resources.HunterLeft__1_
                , Properties.Resources.HunterLeft__1_
                , Properties.Resources.HunterLeft__2_
                , Properties.Resources.HunterLeft__2_
        };
        Image[] imgDown = new Image[]
        {
            Properties.Resources.HunterDown__1_
                , Properties.Resources.HunterDown__1_
                , Properties.Resources.HunterDown__2_
                , Properties.Resources.HunterDown__2_
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
