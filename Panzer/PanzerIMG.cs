using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class PanzerIMG
    {
        Image[] imgRight = new Image[] 
        {
            Properties.Resources.PanzerRight1
                , Properties.Resources.PanzerRight1
                , Properties.Resources.PanzerRight2
                , Properties.Resources.PanzerRight2
        };
        Image[] imgUp = new Image[]
        {
            Properties.Resources.PanzerUp1
                , Properties.Resources.PanzerUp1
                , Properties.Resources.PanzerUp2
                , Properties.Resources.PanzerUp2
        };
        Image[] imgLeft = new Image[]
        {
            Properties.Resources.PanzerLeft1
                , Properties.Resources.PanzerLeft1
                , Properties.Resources.PanzerLeft2
                , Properties.Resources.PanzerLeft2
        };
        Image[] imgDown = new Image[]
        {
            Properties.Resources.PanzerDown1
                , Properties.Resources.PanzerDown1
                , Properties.Resources.PanzerDown2
                , Properties.Resources.PanzerDown2
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
