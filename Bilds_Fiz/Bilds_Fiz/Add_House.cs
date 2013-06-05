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
        int number
        , numberKvartal
        , square
        , squareF
        , squareFull
        , squareSkver
        , squareGreen
        , squareGarden
        , bad;
            string adress
                , area
                , more;
            DateTime eventDate;
            bool light
                , water
                , hot;

        public frmAdd_House()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allResource()
        {
            if (number == null || numberKvartal == null || adress == null || area == null || eventDate == null ||
                square == null || squareF == null || squareFull == null || squareGarden == null || squareGreen == null ||
                squareSkver == null || bad == null || light == null || water == null || hot == null || more == null)
            {
                MessageBox.Show("Не все поля заполнены, проверьте правильность заполнения и заполните пустые", "Обратите внимание", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
            else
            {
                number = int.Parse(txtNumber.Text);
                numberKvartal = int.Parse(txtNumberKv.Text);
                adress = txtAdress.Text;
                area = txtArea.Text;
                eventDate = dtpEvent.Value;
                square = int.Parse(txtSquare.Text);
                squareF = int.Parse(txtSquareF.Text);
                squareFull = int.Parse(txtSquareFull.Text);
                squareSkver = int.Parse(txtSquareScver.Text);
                squareGreen = int.Parse(txtSquareGreen.Text);
                squareGarden = int.Parse(txtSquareGarden.Text);
                bad = int.Parse(txtBad.Text);
                light = chbLight.Checked;
                water = chbWater.Checked;
                hot = chbHot.Checked;
                more = txtMore.Text;
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            allResource();
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
