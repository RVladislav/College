using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Panzer
{
    class PanzerIMG
    {
        Image imgRight = Properties.Resources.TankEnemyRight;
        Image imgUp = Properties.Resources.TankEnemyUp;
        Image imgLeft = Properties.Resources.TankEnemyLeft;
        Image imgDown = Properties.Resources.TankEnemyDown;

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
