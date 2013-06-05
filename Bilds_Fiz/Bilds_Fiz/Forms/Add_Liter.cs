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

        int numberLiter
            , type
            , year
            , allArea
            , liveArea
            , breakBuild
            , coast
            , floor
            , rooms
            , roomsArea
            , roomsHight
            , roomsFloor;
        string whyBuild
            , whyRooms
            , walls;
        bool myself;

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
                //int[] arrayProperty = new int[5];
                //arrayProperty[0] = int.Parse(txtNumber.Text);
                //if (rbMain.Checked == true)
                //{
                //    arrayProperty[1] = 1;
                //}
                //else
                //{
                //    arrayProperty[1] = 0;
                //}
                //arrayProperty[2] = int.Parse(txtYear.Text);
                //arrayProperty[3] = int.Parse(txtAllarea.Text);
                //arrayProperty[4] = int.Parse(txtLivearea.Text);
                //arrayProperty[5] = int.Parse(txtbreakBuild.Text);
                //arrayProperty[6] = int.Parse(txtCoast.Text);
                //arrayProperty[7] = int.Parse(txtFloor.Text);
                //arrayProperty[8] = int.Parse(txtRooms.Text);
                //arrayProperty[9] = int.Parse(txtRoomsArea.Text);
                //arrayProperty[10] = int.Parse(txtRoomsHight.Text);
                //arrayProperty[11] = int.Parse(txtRoomsFloor.Text);                

                //List<string> listProperty = new List<string>();
                //listProperty.Add(txtWhyBuild.Text);
                //listProperty.Add(txtRoomsWhy.Text);
                //listProperty.Add(txtWall.Text);
                
                //bool myself = chbMyself.Checked;

                //frmMain frm = new frmMain();
                //frm.addLiters34(arrayProperty, listProperty, myself);

                numberLiter = int.Parse(txtNumber.Text);
                if (rbMain.Checked == true)
                {
                    type = 1;
                }
                else
                {
                    type = 0;
                }
                year = int.Parse(txtYear.Text);
                allArea = int.Parse(txtAllarea.Text);
                liveArea = int.Parse(txtAllarea.Text);
                breakBuild = int.Parse(txtbreakBuild.Text);
                coast = int.Parse(txtCoast.Text);
                floor = int.Parse(txtFloor.Text);
                rooms = int.Parse(txtRooms.Text);
                roomsArea = int.Parse(txtRoomsArea.Text);
                roomsHight = int.Parse(txtRoomsHight.Text);
                roomsFloor = int.Parse(txtRoomsFloor.Text);
                whyBuild = txtWhyBuild.Text;
                whyRooms = txtRoomsWhy.Text;
                walls = txtWall.Text;
                myself = chbMyself.Checked;

                frmMain frm = new frmMain();
                frm.addLiters(numberLiter
            , type
            , year
            , allArea
            , liveArea
            , breakBuild
            , coast
            , floor
            , rooms
            , roomsArea
            , roomsHight
            , roomsFloor
        , whyBuild
            , whyRooms
            , walls
         , myself);

                this.Close();
            }
            catch
            {
                MessageBox.Show("Не все поля заполнены. Проверьте правильность ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }

     
    }
}
