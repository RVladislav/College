using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GraphicsApp1
{
    public partial class Main : Form
    {
        bool doDraw = false;
        int[] savePointX, savePointY;
        int i = 0;
        Graphics g;

        public Main()
        {
            InitializeComponent();

            savePointX = new int[300];
            savePointY = new int[300];
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;

            checkSplit();
            //showArray();            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (doDraw)
            {
                g = Graphics.FromHwnd(pnlPaint.Handle);
                SolidBrush redBrush = new SolidBrush(Color.Red);
                g.FillEllipse(redBrush, e.X, e.Y, 5, 5);

                lblX.Text = e.X.ToString();
                lblY.Text = e.Y.ToString();

                savePoints(e.X, e.Y);
                
            }

            toolblX.Text = e.X.ToString();
            toolblY.Text = e.Y.ToString();
        }

        public void savePoints(int x, int y)
        {
            if (doDraw)
            {
                try
                {
                    savePointX[i] = x;
                    savePointY[i] = y;
                    i++;
                }
                catch
                {
                    toolblStatus.Text = "Массив переполнен!";
                }
            }
            
        }

        public void cls()
        {
            g.Clear(System.Drawing.Color.White);
            toolblStatus.Text = null;
            txtArrayX.Text = null;
            txtArrayY.Text = null;
            i = 0;

            for (int j = 0; j < i; j++)
            {
                savePointX[j] = 0;
                savePointY[j] = 0;
                
            }
        }

        public void checkSplit()
        {
            //алгоритм определения замкнутой фигуры
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            cls();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtArrayX.Text = null;
            txtArrayY.Text = null;

            for (int j = 0; j < i; j++)
            {
                txtArrayX.Text += savePointX[j].ToString() + "\n\t";
                txtArrayY.Text += savePointY[j].ToString() + "\n\t";
            }
        }

     

  

    }
}
