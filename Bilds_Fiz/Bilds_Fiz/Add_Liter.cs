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

        private void allResource()
        {
            if (numberLiter == null || type == null || year == null || allArea == null || liveArea == null ||
                breakBuild == null || coast == null || floor == null || rooms == null || roomsArea == null ||
                roomsHight == null || roomsFloor == null || whyBuild == null || whyRooms == null || walls == null || myself == null)
            {
                MessageBox.Show("Не все поля заполнены, проверьте правильность заполнения и заполните пустые", "Обратите внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                numberLiter = int.Parse(txtNumber.Text);
                type = int.Parse(txtType.Text);
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
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            allResource();
        }
    }
}
