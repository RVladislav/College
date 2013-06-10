using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bilds_Fiz
{

    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
        }



        public void addBuilds(int[] arrayProperty, List<string> listProperty, DateTime eventDate, bool light, bool water, bool hot)
        {
            string ev = eventDate.ToShortDateString();
            eventDate = DateTime.Parse(ev);

            dgvOne.DataSource = null;
            //Build
            TA_build.Insert(arrayProperty[0], arrayProperty[1].ToString(), listProperty[0], listProperty[1], eventDate);
            TA_build.Fill(DS_Build_Fiz.Build);
            dgvOne.DataSource = BS_build;
            //About_S            
            TA_buildAboutS.Insert(arrayProperty[0], arrayProperty[2], arrayProperty[3], arrayProperty[4], arrayProperty[5], arrayProperty[6], arrayProperty[7]);
            TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
            dgvOne.DataSource = BS_buildAboutS;            
            //About
            TA_buildAbout.Insert(arrayProperty[0], arrayProperty[8], light, water, hot, listProperty[2]);
            TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
            dgvOne.DataSource = BS_buildAbout;
            

            TA_buildAboutS.Update(DS_Build_Fiz.Build_About_S);
            TA_buildAbout.Update(DS_Build_Fiz.Build_About);
            TA_build.Update(DS_Build_Fiz.Build);

        }



        public void addLiters(bool myself, int[] arrayProperty, List<string> listProperty)
        {
            
            dgvOne.DataSource = null;
            //Build-Liter
            TA_build_Liter.Insert(arrayProperty[0], arrayProperty[12]);
            TA_build_Liter.Fill(DS_Build_Fiz.Build_Liter);
            dgvOne.DataSource = BS_buildLiter;
            //Liter
            byte type = byte.Parse(arrayProperty[1].ToString());
            TA_liter.Insert(arrayProperty[0], listProperty[0], type, myself, arrayProperty[2], arrayProperty[3], arrayProperty[4], arrayProperty[5], listProperty[1], arrayProperty[6], arrayProperty[7], arrayProperty[8]
                , listProperty[2], arrayProperty[9], arrayProperty[10], arrayProperty[11]);
            TA_liter.Fill(DS_Build_Fiz.Liter);
            dgvOne.DataSource = BS_liter;

            TA_build_Liter.Update(DS_Build_Fiz.Build_Liter);
            TA_liter.Update(DS_Build_Fiz.Liter);

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
            // TODO: This line of code loads data into the 'DS_Build_Fiz.Build_Liter' table. You can move, or remove it, as needed.
            //this.TA_build_Liter.Fill(this.DS_Build_Fiz.Build_Liter);
            // TODO: This line of code loads data into the 'DS_Build_Fiz.BuildAllInfo' table. You can move, or remove it, as needed.
            //this.TA_buildAllInfo.Fill(this.DS_Build_Fiz.BuildAllInfo);

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
                this.TA_build.Fill(this.DS_Build_Fiz.Build);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private int picPic(int n)
        {
           switch(n)
           {
               case 1: 
                   pictureBox1.Image = Properties.Resources._1;
                   pictureBox2.Image = Properties.Resources._1;
                   pictureBox3.Image = Properties.Resources._2;
            break;
               case 2:
            pictureBox1.Image = Properties.Resources._2;
            pictureBox2.Image = Properties.Resources._1;
            pictureBox3.Image = Properties.Resources._1;
            break;
               case 3:
            pictureBox1.Image = Properties.Resources._1;
            pictureBox2.Image = Properties.Resources._2;
            pictureBox3.Image = Properties.Resources._1;
            break;
        }
           return 0;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            TA_build.Fill(DS_Build_Fiz.Build);
            dgvOne.DataSource = DS_Build_Fiz.Build;
            dgvOne.Update();

            picPic(2);

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            TA_buildAbout.Fill(DS_Build_Fiz.Build_About);
            dgvOne.DataSource = DS_Build_Fiz.Build_About;
            dgvOne.Update();

                    
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            TA_buildAboutS.Fill(DS_Build_Fiz.Build_About_S);
            dgvOne.DataSource = DS_Build_Fiz.Build_About_S;
            dgvOne.Update();

           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            TA_liter.Fill(DS_Build_Fiz.Liter);
            dgvOne.DataSource = DS_Build_Fiz.Liter;
            dgvOne.Update();

            picPic(3);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OpenView(2);
        }

       

        private void label4_Click(object sender, EventArgs e)
        {
            OpenView(3);
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

        private void label5_Click(object sender, EventArgs e)
        {
            OpenView(1);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            TA_buildAllInfo.Fill(DS_Build_Fiz.BuildAllInfo);
            dgvOne.DataSource = DS_Build_Fiz.BuildAllInfo;
            dgvOne.Update();

            picPic(1);
        }

        private void вДокументToolStripMenuItem_Click(object sender, EventArgs e)
        {


            try
            {
                string table = dgvOne.DataSource.ToString();
                frmDocument frm = new frmDocument();
                List<string> str = new List<string>();

                switch (table)
                {
                    case "Build":
                        docBuildShot(frm, str);
                        break;
                    case "Liter":
                        docLiter(frm, str);
                        break;
                    case "BuildAllInfo":
                        docBuildAllInfo(frm, str);
                        break;
                }
                frm.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Не открыта таблица", "Ошибка чтения данных из таблицы", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
                
          
        }

        private void docBuildAllInfo(frmDocument frm, List<string> str)
        {
            DateTime date = new DateTime();
            date = DateTime.Parse(dgvOne.CurrentRow.Cells[4].Value.ToString());

            str.Add("BuildAllInfo");
            str.Add(dgvOne.CurrentRow.Cells[0].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[1].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[2].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[3].Value.ToString());
            str.Add(date.ToShortDateString());
            str.Add(dgvOne.CurrentRow.Cells[5].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[6].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[7].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[8].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[9].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[10].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[11].Value.ToString());
            if (bool.Parse(dgvOne.CurrentRow.Cells[12].Value.ToString()) == true)
            {
                str.Add("Есть");
            }
            else
            {
                str.Add("Отсутствует");
            }
            if (bool.Parse(dgvOne.CurrentRow.Cells[13].Value.ToString()) == true)
            {
                str.Add("Есть");
            }
            else
            {
                str.Add("Отсутствует");
            }
            if(bool.Parse(dgvOne.CurrentRow.Cells[14].Value.ToString()) == true)
            {
                str.Add("Есть");
            }
            else
            {
                str.Add("Отсутствует");
            }

            str.Add(dgvOne.CurrentRow.Cells[15].Value.ToString());            
            
            frm.doc(str);
        }

        private void docLiter(frmDocument frm, List<string> str)
        {
            str.Add("Liter");
            str.Add(dgvOne.CurrentRow.Cells[0].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[1].Value.ToString());

            if (dgvOne.CurrentRow.Cells[2].Value.ToString() == "1")
            {
                str.Add("Основной");
            }
            else
            {
                str.Add("Дополнительный");
            }

            str.Add(dgvOne.CurrentRow.Cells[3].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[4].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[5].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[6].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[7].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[8].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[9].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[10].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[11].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[12].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[13].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[14].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[15].Value.ToString());

            frm.doc(str);
         
        }

        private void docBuildShot(frmDocument frm, List<string> str)
        {
            DateTime date = DateTime.Parse(dgvOne.CurrentRow.Cells[4].Value.ToString());
            
            str.Add("Build");
            str.Add(dgvOne.CurrentRow.Cells[0].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[1].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[2].Value.ToString());
            str.Add(dgvOne.CurrentRow.Cells[3].Value.ToString());
            str.Add(date.ToShortDateString());

            frm.doc(str);  
        }

      

        //Обновление таблицы

        //dgvOne.DataSource = null;
        //TA_liter.Fill(DS_Build_Fiz.Liter);
        //dgvOne.DataSource = BS_liter;

    }
}
