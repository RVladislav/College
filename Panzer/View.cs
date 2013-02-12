using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Panzer
{
    partial class View : UserControl
    {
        Model model;
        public View(Model model)
        {
            InitializeComponent();
            this.model = model;
        }

        void DrawWall(PaintEventArgs e)
        {
            for (int y = 20; y < 300; y += 40)
            {
                for (int x = 20; x < 260; x += 40)
                {
                    e.Graphics.DrawImage(model.wall.Img, new Point(x, y));
                }
            }

        }

        void DrawPanzer(PaintEventArgs e)
        {
            foreach(Panzer t in model.Panzers)
                e.Graphics.DrawImage(t.CurrentImg, new Point(t.X, t.Y));
        }

        void Draw(PaintEventArgs e)
        {
            DrawWall(e);
            DrawPanzer(e);

            if (model.gameStatus != GameStatus.playing)
            {
                return;
            }

            Thread.Sleep(model.speedGame);
            
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Draw(e);
        }
    }
}
