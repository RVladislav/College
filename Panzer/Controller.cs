﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Panzer
{
    public partial class Controller_frmMain : Form
    {
        View view;
        Model model;
        Thread modelPlay;

        public Controller_frmMain() : this(260) { }
        public Controller_frmMain(int sizeField) : this(sizeField, 5) { }
        public Controller_frmMain(int sizeField, int amountPanzer) : this(sizeField, amountPanzer, 5) { }
        public Controller_frmMain(int sizeField, int amountPanzer, int amountApples) : this(sizeField, amountPanzer, amountApples, 50) { }

        public Controller_frmMain(int sizeField, int amountPanzer, int amountApples, int speedGame)
        {
            InitializeComponent();
            model = new Model(sizeField, amountApples, amountApples, speedGame);
            view = new View(model);
            this.Controls.Add(view);
            model.gameStatus = GameStatus.stopping;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (model.gameStatus == GameStatus.playing)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stopping;
            }
            else
            {
                modelPlay = new Thread(model.Play);
                modelPlay.Start();
                model.gameStatus = GameStatus.playing;
                view.Invalidate();
            }
        }

        private void Controller_frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (modelPlay != null)
            {
                modelPlay.Abort();
                model.gameStatus = GameStatus.stopping;
            }
            DialogResult dr = MessageBox.Show("Конец игры?", "Panzer - Razhnov VG", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
