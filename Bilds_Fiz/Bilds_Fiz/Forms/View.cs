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
    public partial class frmView : Form
    {
        public frmView()
        {
            InitializeComponent();
        }

        public int OpenTable(int n)
        {
            switch (n)
            {
                case 1:
                    this.TA_build.Fill(this.dS_Build_Fiz.Build);
                    dgvView.DataSource = BS_build;
                    this.Text = "Дома";
                    break;
                case 2:
                    this.TA_buildAbout.Fill(this.dS_Build_Fiz.Build_About);
                    dgvView.DataSource = BS_buildAbout;
                    this.Text = "Дома. Информация";
                    break;
                case 3:
                    this.TA_buildAboutS.Fill(this.dS_Build_Fiz.Build_About_S);
                    dgvView.DataSource = BS_buildAboutS;
                    this.Text = "Дома. Площадь";
                    break;
                case 4:
                    this.TA_liter.Fill(this.dS_Build_Fiz.Liter);
                    dgvView.DataSource = BS_liter;
                    this.Text = "Литер";
                    break;
                case 5:
                    this.TA_buildAllInfo.Fill(this.dS_Build_Fiz.BuildAllInfo);
                    dgvView.DataSource = BS_buildAllInfo;
                    this.Text = "Литер";
                    break; 
            }
            return 0;
        }

        private void frmView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Build_Fiz.BuildAllInfo' table. You can move, or remove it, as needed.
            this.TA_buildAllInfo.Fill(this.dS_Build_Fiz.BuildAllInfo);
           
        }
    }
}
