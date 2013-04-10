using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace GraphicsDraw
{
    public partial class frmMain : Form
    {
        bool doDraw = false;
        byte sizeBrushX = 3
            , sizeBrushY = 3;

        int c = 0
            , sizeArray = 500;

        float[] savePointX
            , savePointY;

        Graphics g;

        public frmMain()
        {
            InitializeComponent();

            savePointX = new float[sizeArray];
            savePointY = new float[sizeArray];

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

                if (c < sizeArray)
                {
                    savePointX[c] = e.X;
                    savePointY[c] = e.Y;
                    c++;
                    progressBar.Value = c;
                }
                else
                {
                    toolblStatus.Text = "Full!";
                }

            }

            toolblX.Text = e.X.ToString();
            toolblY.Text = e.Y.ToString();
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
            progressBar.Value = 0;
            c = 0;
            //savePointX = null;
            //savePointY = null;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            txtArrayX.Text = null;
            txtArrayY.Text = null;

            for (int i = 0; i < sizeArray; i++)
            {
                txtArrayX.Text += savePointX[i].ToString() + "\r\n";
                txtArrayY.Text += savePointY[i].ToString() + "\r\n";
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
                progressBar.Value = 0;

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
                            X[Xlenght] = float.Parse(numberX);
                            numberX = "";
                            Xlenght++;

                        }
                    }
                    
                }


                try
                {
                    X[Xlenght] = float.Parse(numberX);
                    numberX = "";
                    Xlenght++;
                }
                catch { }


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

                            Y[Ylenght] = float.Parse(numberY);
                            numberY = "";
                            Ylenght++;

                        }
                    }
                    
                }


                try
                {
                    Y[Ylenght] = float.Parse(numberY);
                    numberY = "";
                    Ylenght++;
                }
                catch { }

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

                            g.FillEllipse(brush, X[n], Y[n], sizeBrushX, sizeBrushY);

                            n++;
                        }
                        
                    }

                }
                catch
                {
                    toolblStatus.Text = "Error when drawing. Please restart and check input data";
                    progressBar.Value = 0;
                }
                pen.Dispose();
                g.Dispose();
            }
            catch
            {
                toolblStatus.Text = "X and/or Y   = NULL";
                progressBar.Value = 0;
            }
        }


    }
}//Razhnov Vladislav/
