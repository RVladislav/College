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
    public partial class frmAdd_Liter : Form
    {

        public frmAdd_Liter()
        {
            InitializeComponent();
        }        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                bool myself = chbMyself.Checked;

                int[] arrayProperty = new int[13];
                arrayProperty[0] = int.Parse(txtNumber.Text);
                if (rbMain.Checked == true)
                {
                    arrayProperty[1] = 1;
                }
                else
                {
                    arrayProperty[1] = 0;
                }
                arrayProperty[2] = int.Parse(txtYear.Text);
                arrayProperty[3] = int.Parse(txtAllarea.Text);
                arrayProperty[4] = int.Parse(txtLivearea.Text);
                arrayProperty[5] = int.Parse(txtbreakBuild.Text);
                arrayProperty[6] = int.Parse(txtCoast.Text);
                arrayProperty[7] = int.Parse(txtFloor.Text);
                arrayProperty[8] = int.Parse(txtRooms.Text);
                arrayProperty[9] = int.Parse(txtRoomsArea.Text);
                arrayProperty[10] = int.Parse(txtRoomsHight.Text);
                arrayProperty[11] = int.Parse(txtRoomsFloor.Text);
                arrayProperty[12] = int.Parse(cmbNumberBuild.Text);


                List<string> listProperty = new List<string>();
                listProperty.Add(txtWhyBuild.Text);
                listProperty.Add(txtWall.Text);
                listProperty.Add(txtRoomsWhy.Text);

                frmMain frm = new frmMain();
                frm.addLiters(myself, arrayProperty, listProperty);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены. Проверьте правильность ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

        private void frmAdd_Liter_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dS_Build_Fiz.Build' table. You can move, or remove it, as needed.
            this.TA_build.Fill(this.dS_Build_Fiz.Build);

        }

     
    }
}
