using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bilds_Fiz
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private int OpenView(int n)
        {
            frmView frm = new frmView();
            frm.Show();
            frm.OpenTable(n);

            return 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS_Build_Fiz.Liter' table. You can move, or remove it, as needed.
            this.TA_liter.Fill(this.DS_Build_Fiz.Liter);
            // TODO: This line of code loads data into the 'DS_Build_Fiz.Build_About_S' table. You can move, or remove it, as needed.
            this.TA_buildAboutS.Fill(this.DS_Build_Fiz.Build_About_S);
            // TODO: This line of code loads data into the 'DS_Build_Fiz.Build_About' table. You can move, or remove it, as needed.
            this.TA_buildAbout.Fill(this.DS_Build_Fiz.Build_About);
            // TODO: This line of code loads data into the 'dS_Build_Fiz.Liter' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'dS_Build_Fiz.Build' table. You can move, or remove it, as needed.
            this.TA_build.Fill(this.DS_Build_Fiz.Build);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutTheAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout_Autor frm = new frmAbout_Autor();

            frm.ShowDialog();
        }

        private void programmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAbout_Programm frm = new frmAbout_Programm();

            frm.ShowDialog();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void fillBuildToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.TA_build.FillBuild(this.DS_Build_Fiz.Build);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte a = 10;
            int aa = 2;
            string b = "dfd";
            string c = "trtrtrtr";
            string d = "oii";
            DateTime dt = new DateTime(2013, 2, 10);



            //About_S
            TA_buildAboutS.Insert(a, a, a, a, a, a, a);
            dgvOne.DataSource = null;
            TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
            dgvOne.DataSource = BS_buildAboutS;
            //About
            TA_buildAbout.Insert(a, aa, true, true, true, c);
            dgvOne.DataSource = null;
            TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
            dgvOne.DataSource = BS_buildAbout;
            //Build
            TA_build.Insert(a, b, c, d, dt);
            dgvOne.DataSource = null;
            TA_build.Fill(DS_Build_Fiz.Build);
            dgvOne.DataSource = BS_build;

        }

        private int picPic(int n)
        {
            switch (n)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._2;
                    pictureBox2.Image = Properties.Resources._1;
                    pictureBox3.Image = Properties.Resources._1;
                    pictureBox4.Image = Properties.Resources._1;
                    break;
                case 2:
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox2.Image = Properties.Resources._2;
                    pictureBox3.Image = Properties.Resources._1;
                    pictureBox4.Image = Properties.Resources._1;
                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox2.Image = Properties.Resources._1;
                    pictureBox3.Image = Properties.Resources._2;
                    pictureBox4.Image = Properties.Resources._1;
                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._1;
                    pictureBox2.Image = Properties.Resources._1;
                    pictureBox3.Image = Properties.Resources._1;
                    pictureBox4.Image = Properties.Resources._2;
                    break;
            }
            return 0;
        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TA_build.Fill(DS_Build_Fiz.Build);
            dgvOne.DataSource = DS_Build_Fiz.Build;
            dgvOne.Update();

            picPic(1);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
            dgvOne.DataSource = DS_Build_Fiz.Build_About;
            dgvOne.Update();

            picPic(2);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
            dgvOne.DataSource = DS_Build_Fiz.Build_About_S;
            dgvOne.Update();

            picPic(3);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TA_liter.Fill(DS_Build_Fiz.Liter);
            dgvOne.DataSource = DS_Build_Fiz.Liter;
            dgvOne.Update();

            picPic(4);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenView(1);
        }

        private void label2_Click(object sender, EventArgs e)
        {
            OpenView(2);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            OpenView(3);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenView(4);
        }

        private void домToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_House frm = new frmAdd_House();
            frm.ShowDialog();
        }

        private void литерToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdd_Liter frm = new frmAdd_Liter();
            frm.ShowDialog();
        }

      
      
    }
}
