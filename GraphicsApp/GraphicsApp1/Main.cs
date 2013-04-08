using System;
using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
using System.Drawing;
//using System.Linq;
//using System.Text;
using System.Windows.Forms;

namespace GraphicsDraw
{
    public partial class Main : Form
    {
        bool doDraw = false;
        byte sizeBrushX = 3
            , sizeBrushY = 3;

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
                g.FillEllipse(redBrush, e.X, e.Y, sizeBrushX, sizeBrushY);

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
                    toolblStatus.Text = "Full!";
                }
            }
            
        }

        public void checkSplit()
        {
            //Проверка на замкнутость
        }

        private void btnCls_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(System.Drawing.Color.White);
            }
            catch {
            }
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

        private void cmbSizeBrush_SelectedIndexChanged(object sender, EventArgs e)
        {
            string size = cmbSizeBrush.Text.ToString();

            switch (size)
            {
                case "Small":
                    sizeBrushX = 3;
                    sizeBrushY = 3;
                    break;
                case "Normal":
                    sizeBrushX = 5;
                    sizeBrushY = 5;
                    break;
                case "Big":
                    sizeBrushX = 7;
                    sizeBrushY = 7;
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g = Graphics.FromHwnd(pnlPaint.Handle);
            Pen pen = new Pen(Color.Green, sizeBrushX);          

            float[] X
                , Y;
            string numberX=""
                , numberY="";
            string inputX = "106 107 108 109 110 111 112 113 114 115 116 117 118 119 120 121 122 123 124 125 126 127 128 129 130 131 132 133 134 135 136 137 138 139 140 141 142 143";
            string inputY = "78 79 80 81 82 83 84 85 86 87 88 89 90 91 92 93 94 95 96 97 98 99 100 101 102 103 104 105 106 107 108 109 110 111 112 113 114";

            X = new float[inputX.Length];
            Y = new float[inputY.Length];

            int Xlenght = 0
                ,Ylenght=0
                ,max = 0;

            for (int i = 0; i < inputX.Length; i++)
            {
                if (inputX[i].ToString() != " ")
                {
                    numberX += inputX[i].ToString();
                }
                else
                {
                    X[Xlenght] = float.Parse(numberX);
                    numberX = "";
                    Xlenght++;
                }
            }

            X[Xlenght] = float.Parse(numberX);
            numberX = "";
            Xlenght++;

            for (int i = 0; i < inputY.Length; i++)
            {
                if (inputY[i].ToString() != " ")
                {
                    numberY += inputY[i].ToString();
                }
                else
                {
                    Y[Ylenght] = float.Parse(numberY);
                    numberY = "";
                    Ylenght++;
                }
            }

            Y[Ylenght] = float.Parse(numberY);
            numberY = "";
            Ylenght++;

            if (Xlenght >= Ylenght)
            {
                max = Xlenght;
            }
            else
            {
                max = Ylenght;
            }
            //for (int r = 0; r < max - 1; max++)
            //{
            //    g.DrawLine(pen, x[r], y[r], x[r + 1], y[r + 1]);
            //}
            
        }

    }
}//Razhnov Vladislav/
