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
    public partial class frmMenu : Form
    {
        bool check = false;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (check == false)
            {
                if (txtLogin.Text == "Vladislav" && txtPassword.Text == "Razhnov" || txtLogin.Text == "Marina" && txtPassword.Text == "Erina")
                {
                    frmMain frm = new frmMain();

                    frm.Show();
                }
                check = true;
            }            
        }

  

        private void lblLinkExit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Application.Exit();
        }
    }
}
