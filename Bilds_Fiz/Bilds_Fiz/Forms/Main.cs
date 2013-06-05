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
        
        public object addBuilds(int[] arrayProperty, List<string> listProperty, DateTime eventDate, bool light, bool water, bool hot)
        {
            byte n = Convert.ToByte(arrayProperty[0]);
            string ev = eventDate.ToShortDateString();
            eventDate = DateTime.Parse(ev);

            dgvOne.DataSource = null;
            //About_S            
            TA_buildAboutS.Insert(n, arrayProperty[2], arrayProperty[3], arrayProperty[4], arrayProperty[5], arrayProperty[6], arrayProperty[7]);
            TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
            dgvOne.DataSource = BS_buildAboutS;
            //About
            TA_buildAbout.Insert(n, arrayProperty[8], light, water, hot, listProperty[2]);
            TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
            dgvOne.DataSource = BS_buildAbout;
            //Build
            TA_build.Insert(n, arrayProperty[1].ToString(), listProperty[0], listProperty[1], eventDate);
            TA_build.Fill(DS_Build_Fiz.Build);
            dgvOne.DataSource = BS_build;

            TA_buildAboutS.Update(DS_Build_Fiz.Build_About_S);
            TA_buildAbout.Update(DS_Build_Fiz.Build_About);
            TA_build.Update(DS_Build_Fiz.Build);
            
            return 0;
        }

        //public object addLiters34(int[] arrayProperty, List<string> listProperty, bool myself)
        //{
        //    byte r = Convert.ToByte(numberLiter);
        //    byte f = Convert.ToByte(floor);
        //    byte t = Convert.ToByte(type);
        //    byte la = Convert.ToByte(liveArea);
        //    byte al = Convert.ToByte(allArea);
        //    byte n = Convert.ToByte(numberLiter);
        //    byte bb = Convert.ToByte(breakBuild);
        //    dgvOne.DataSource = null;
        //    TA_liter.Insert(n, whyBuild, t, myself, byte.Parse(year.ToString()), al, la, bb, walls, coast, f, r, whyRooms, roomsArea, roomsHight, roomsFloor);
        //    TA_liter.Fill(DS_Build_Fiz.Liter);
        //    dgvOne.DataSource = BS_buildAboutS;

        //    TA_liter.Update(DS_Build_Fiz.Liter);

        //    return 0;
        //}


        public object addLiters(
            int numberLiter
            , int type
            , int year
            , int allArea
            , int liveArea
            , int breakBuild
            , int coast
            , int floor
            , int rooms
            , int roomsArea
            , int roomsHight
            , int roomsFloor
            , string whyBuild
            , string whyRooms
            , string walls
        , bool myself
            )
        {
            byte r = Convert.ToByte(numberLiter);
            byte f = Convert.ToByte(floor);
            byte t = Convert.ToByte(type);
            byte la = Convert.ToByte(liveArea);
            byte al = Convert.ToByte(allArea);
            byte n = Convert.ToByte(numberLiter);
            byte bb = Convert.ToByte(breakBuild);
            dgvOne.DataSource = null;
            //Liter
            TA_liter.Insert(n, whyBuild, t, myself, byte.Parse(year.ToString()), al, la, bb, walls, coast, f, r, whyRooms, roomsArea, roomsHight, roomsFloor);
            TA_liter.Fill(DS_Build_Fiz.Liter);
            dgvOne.DataSource = BS_buildAboutS;

            TA_liter.Update(DS_Build_Fiz.Liter);

            return 0;
        }

        //public object addBuilds(
        //    int number
        // , int numberKvartal
        // , int square
        // , int squareF
        // , int squareFull
        // , int squareSkver
        // , int squareGreen
        // , int squareGarden
        // , int bad
        //    , string adress
        //         , string area
        //         , string more
        //    , DateTime eventDate
        //    , bool light
        //         , bool water
        //         , bool hot)
        //{
        //    byte n = Convert.ToByte(number);
        //    string ev = eventDate.ToShortDateString();
        //    eventDate = DateTime.Parse(ev);

        //    dgvOne.DataSource = null;
        //    //About_S            
        //    TA_buildAboutS.Insert(n, square, squareF, squareFull, squareSkver, squareGreen, squareGarden);
        //    TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
        //    dgvOne.DataSource = BS_buildAboutS;
        //    //About
        //    TA_buildAbout.Insert(n, bad, light, water, hot, more);
        //    TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
        //    dgvOne.DataSource = BS_buildAbout;
        //    //Build
        //    TA_build.Insert(n, numberKvartal.ToString(), adress, area, eventDate);
        //    TA_build.Fill(DS_Build_Fiz.Build);
        //    dgvOne.DataSource = BS_build;

        //    TA_buildAboutS.Update(DS_Build_Fiz.Build_About_S);
        //    TA_buildAbout.Update(DS_Build_Fiz.Build_About);
        //    TA_build.Update(DS_Build_Fiz.Build);           
            
        //    return 0;
        //}

        private int OpenView(int n)
        {
            frmView frm = new frmView();
            frm.Show();
            frm.OpenTable(n);

            return 0;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

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

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    byte a = 10;
        //    int aa = 2;
        //    string b = "dfd";
        //    string c = "trtrtrtr";
        //    string d = "oii";
        //    DateTime dt = new DateTime(2013, 2, 10);



        //    //About_S
        //    TA_buildAboutS.Insert(a, a, a, a, a, a, a);
        //    dgvOne.DataSource = null;
        //    TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
        //    dgvOne.DataSource = BS_buildAboutS;
        //    //About
        //    TA_buildAbout.Insert(a, aa, true, true, true, c);
        //    dgvOne.DataSource = null;
        //    TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
        //    dgvOne.DataSource = BS_buildAbout;
        //    //Build
        //    TA_build.Insert(a, b, c, d, dt);
        //    dgvOne.DataSource = null;
        //    TA_build.Fill(DS_Build_Fiz.Build);
        //    dgvOne.DataSource = BS_build;

        //}

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

        private void выделеннуюСтрокуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


    }
}
