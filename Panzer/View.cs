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

        void Draw(PaintEventArgs e)
        {
            e.Graphics.DrawImage(model.panzer.Img, new Point(model.panzer.X, model.panzer.Y));
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
