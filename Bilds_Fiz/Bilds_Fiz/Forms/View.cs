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
        int nTable;
        public frmView()
        {
            InitializeComponent();
        }

        public int OpenTable(int n)
        {
            switch (n)
            {
                case 2:
                    this.TA_build.Fill(this.dS_Build_Fiz.Build);
                    dgvView.DataSource = BS_build;
                    this.Text = "Дома. Кратко";
                    break;                
                case 3:
                    this.TA_liter.Fill(this.dS_Build_Fiz.Liter);
                    dgvView.DataSource = BS_liter;
                    this.Text = "Литер";
                    break;
                case 1:
                    this.TA_buildAllInfo.Fill(this.dS_Build_Fiz.BuildAllInfo);
                    dgvView.DataSource = BS_buildAllInfo;
                    this.Text = "Дома";
                    break; 
            }
            nTable = n;
            return 0;
        }

    
               
    }
}
