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

            System.Drawing.Drawing2D.QualityMode Quality = new System.Drawing.Drawing2D.QualityMode();
            System.Drawing.Drawing2D.SmoothingMode Smoothing = new System.Drawing.Drawing2D.SmoothingMode();
            Quality = System.Drawing.Drawing2D.QualityMode.High;
            Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            doDraw = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            doDraw = false;
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



        private void btnCls_Click(object sender, EventArgs e)
        {
            try
            {
                g.Clear(System.Drawing.Color.White);
            }
            catch
            {
            }
            pnlPaint.Refresh();
            toolblStatus.Text = null;
            txtArrayX.Text = null;
            txtArrayY.Text = null;
            progressbar.Value = 0;
            savePointX.Clear();
            savePointY.Clear();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            int val = 0;

            txtArrayX.Text = null;
            txtArrayY.Text = null;
                foreach (int elem in savePointX)
                {
                    txtArrayX.Text += elem.ToString() + "\r\n";
                    if (val < progressbar.Maximum)
                    {
                        val++;
                    }
                    progressbar.Value = val;
                }

                foreach (int elem in savePointY)
                {
                    txtArrayY.Text += elem.ToString() + "\r\n";
                    if (val < progressbar.Maximum)
                    {
                        val++;
                    }
                    progressbar.Value = val;

                }
                progressbar.Value = progressbar.Maximum;
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

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                float[] X
                    , Y;
                Pen pen = new Pen(Color.Green, sizeBrushX);
                SolidBrush brush = new SolidBrush(Color.Green);
                g = Graphics.FromHwnd(pnlPaint.Handle);

                string numberX = ""
                    , numberY = "";
                string inputX = txtArrayX.Text;
                string inputY = txtArrayY.Text;

                if (inputX.Length > inputY.Length)
                {
                    X = new float[inputX.Length];
                    Y = new float[inputX.Length];
                }
                else
                {
                    X = new float[inputY.Length];
                    Y = new float[inputY.Length];
                }

                int Xlenght = 0
                    , Ylenght = 0
                    , n = 0
                    , nNextX = 0
                    , nNextY = 0
                    , val = 0;

                toolblStatus.Text = null;
                progressbar.Value = 0;

                for (int i = 0; i < inputX.Length; i++)
                {
                    if (inputX[i].ToString() != " " && inputX[i].ToString() != "\r" && inputX[i].ToString() != "\n")
                    {
                        numberX += inputX[i].ToString();
                    }
                    else
                    {
                        if (numberX.ToString() == "")
                        {
                        }
                        else
                        {
                            // if (int.Parse(numberX) <= pnlPaint.Size.Width)
                            //{

                            X[Xlenght] = float.Parse(numberX);
                            numberX = "";
                            Xlenght++;
                            // }
                        }
                    }
                    if (val < progressbar.Maximum)
                    {
                        val++;
                    }
                    progressbar.Value = val;
                }

                //if (int.Parse(numberX) <= pnlPaint.Size.Width)
                //{
                try
                {
                    X[Xlenght] = float.Parse(numberX);
                    numberX = "";
                    Xlenght++;
                }
                catch { }
                //}

                for (int i = 0; i < inputY.Length; i++)
                {
                    if (inputY[i].ToString() != " " && inputY[i].ToString() != "\r" && inputY[i].ToString() != "\n")
                    {
                        numberY += inputY[i].ToString();
                    }
                    else
                    {
                        if (numberY.ToString() == "")
                        {
                        }
                        else
                        {
                            //if (int.Parse(numberY) <= pnlPaint.Size.Height)
                            //{
                            Y[Ylenght] = float.Parse(numberY);
                            numberY = "";
                            Ylenght++;
                            //}
                        }
                    }
                    if (val < progressbar.Maximum)
                    {
                        val++;
                    }
                    progressbar.Value = val;
                }

                //if (int.Parse(numberY) <= pnlPaint.Size.Height)
                //{
                try
                {
                    Y[Ylenght] = float.Parse(numberY);
                    numberY = "";
                    Ylenght++;
                }
                catch { }
                //}
                int max = Xlenght;
                if (Xlenght > Ylenght)
                {
                    max = Xlenght;
                }
                else
                {
                    max = Ylenght;
                }

                try
                {
                    pnlPaint.Refresh();
                    for (int i = 0; i < max; i++)
                    {
                        while (Xlenght > n)
                        {
                            nNextX = n + 1;
                            nNextY = n + 1;

                            if (X[nNextX] == 0)
                            {
                                X[nNextX] = X[nNextX - 1];
                            }

                            if (Y[nNextY] == 0)
                            {
                                Y[nNextY] = Y[nNextY - 1];
                            }

                            switch (cmbChangeDraw.Text)
                            {
                                case "1":
                                    g.DrawLine(pen, X[n], Y[n], X[nNextX], Y[nNextY]);
                                    break;
                                case "2":
                                    g.FillEllipse(brush, X[n], Y[n], sizeBrushX, sizeBrushY);
                                    break;
                            }


                            n++;
                        }
                        if (val < progressbar.Maximum)
                        {
                            val++;
                        }
                        progressbar.Value = val;
                    }

                }
                catch
                {
                    toolblStatus.Text = "Error when drawing. Please restart and check input data";
                    progressbar.Value = 0;
                }
                pen.Dispose();
                g.Dispose();
            }
            catch
            {
                toolblStatus.Text = "X and/or Y   = NULL";
                progressbar.Value = 0;
            }
            progressbar.Value = progressbar.Maximum;
        }


    }
}//Razhnov Vladislav/
