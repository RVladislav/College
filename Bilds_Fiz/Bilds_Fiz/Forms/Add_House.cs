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
    public partial class frmAdd_House : Form
    {
        public frmAdd_House()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }      

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                DateTime eventDate = dtpEvent.Value;
                bool light = chbLight.Checked
                , water = chbWater.Checked
                , hot = chbHot.Checked;
                
                int[] arrayProperty = new int[9];
                arrayProperty[0] = int.Parse(txtNumber.Text);
                arrayProperty[1] = int.Parse(txtNumberKv.Text);
                arrayProperty[2] = int.Parse(txtSquare.Text);
                arrayProperty[3] = int.Parse(txtSquareF.Text);
                arrayProperty[4] = int.Parse(txtSquareFull.Text);
                arrayProperty[5] = int.Parse(txtSquareScver.Text);
                arrayProperty[6] = int.Parse(txtSquareGreen.Text);
                arrayProperty[7] = int.Parse(txtSquareGarden.Text);
                arrayProperty[8] = int.Parse(txtBad.Text);

                List<string> listProperty = new List<string>();
                listProperty.Add(txtAdress.Text);
                listProperty.Add(txtArea.Text);
                listProperty.Add(txtMore.Text);               

                frmMain frm = new frmMain();
                frm.addBuilds(arrayProperty, listProperty, eventDate, light, water, hot);

                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Не все поля заполнены. Проверьте правильность ввода", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

       

       
    }
}
