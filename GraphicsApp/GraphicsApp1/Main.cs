﻿using System;
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
        HashSet<int> savePointX, savePointY;
        Graphics g;

        public Main()
        {
            InitializeComponent();

            savePointX = new HashSet<int>();
            savePointY = new HashSet<int>();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;

            checkSplit();           
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
                    savePointX.Add(x);
                    savePointY.Add(y);
                }
                catch
                {
                    toolblStatus.Text = "Массив переполнен!";
                }
            }
            
        }

        public void checkSplit()
        {
            //алгоритм определения замкнутой фигуры
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            g.Clear(System.Drawing.Color.White);
            toolblStatus.Text = null;
            txtArrayX.Text = null;
            txtArrayY.Text = null;
            savePointX.Clear();
            savePointY.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtArrayX.Text = null;
            txtArrayY.Text = null;

            foreach (int elem in savePointX)
            {

                txtArrayX.Text += elem.ToString() + "\n\t";

            }
            
            foreach (int elem in savePointY)
            {

                txtArrayY.Text += elem.ToString() + "\n\t";

            }
        }

    }
}