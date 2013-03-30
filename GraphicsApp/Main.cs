using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsApp
{
    public partial class Main : Form
    {
        bool doDraw = false;
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                Graphics g = Graphics.FromHwnd(this.Handle);
                SolidBrush redBrush = new SolidBrush(Color.Red);
                g.FillRectangle(redBrush, e.X, e.Y, 1, 1);
            }
        }
    }
}
