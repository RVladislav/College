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
    public partial class frmDocument : Form
    {
        string tableOpenNow;

        public frmDocument()
        {
            InitializeComponent();
        }

        public void doc(List<string> str)
        {
            tableOpenNow = str[0];
            this.Text = tableOpenNow;

            switch(str[0])
            {
                case "Build": 
                    rtxtDoc.Text =
                "Здание № " + str[1]
                + "\nКвартал " + str[2]
                + "\nАдрес " + str[3]
                + "\nРайон " + str[4]
                + "\nДата инвенторизации " + str[5];
                    break;

                case "Liter":
                    rtxtDoc.Text=
                        "Вид " + str[2]
                        + "\nОсновной или дополнительный " + str[3]
                        + "\nСамострой " + str[4]
                        + "\nГод постройки " + str[5]
                        + "\nS-общая " + str[6]
                        + "\nS-жилая " + str[7]
                        + "\nИзнос " + str[8] + "%"
                        + "\nМатериал стен " + str[9]
                        + "\nСтоимость инвентаризации " + str[10] + " руб."
                        + "\nЭтажей " + str[11]
                        + "\nИспользуемых помещений " + str[12]
                        + "\nНазначение " + str[13]
                        + "\nПлощадь помещения " + str[14]
                        + "\nВысота помещения " + str[15]
                        + "\nЭтаж размещения " + str[16];
                    break;

                case "BuildAllInfo":
                    rtxtDoc.Text =
                        "Номер дома " + str[1]
                        + "\nКвартал " + str[2]
                        + "\nАдрес " + str[3]
                        + "\nРайон " + str[4]
                        + "\nДата инвенторизации " + str[5]
                        + "\nS-земли " + str[6]
                        + "\nS-фактическая " + str[7]
                        + "\nS-застройки " + str[8]
                        + "\nS-двора " + str[9]
                        + "\nS-озеленения " + str[10]
                        + "\nS-огорода " + str[11]
                        + "\nНеугодья " + str[12]
                        + "\nОсвещение " + str[13]
                        + "\nВодопровод " + str[14]
                        + "\nОтопление " + str[15]
                        + "\nПримечания " + str[16];
                    break;
        }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog.FileName = "Document_" + tableOpenNow;
            saveFileDialog.Title = "Сохранение документа " + tableOpenNow;
            saveFileDialog.ShowDialog();
        }

        private void цветТекстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            if (rtxtDoc.SelectedText.Length == 0)
            {
                rtxtDoc.ForeColor = colorDialog.Color;
            }
            else
            {
                rtxtDoc.SelectionColor = colorDialog.Color;
            }
        }

        private void цветВыделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            if (rtxtDoc.SelectedText.Length == 0)
            {
                rtxtDoc.BackColor = colorDialog.Color;
            }
            else
            {
                rtxtDoc.SelectionBackColor = colorDialog.Color;
            }
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
           rtxtDoc.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            rtxtDoc.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            rtxtDoc.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog.ShowDialog();
            if (rtxtDoc.SelectedText.Length == 0)
            {
                rtxtDoc.Font = fontDialog.Font;
            }
            else
            {
                rtxtDoc.SelectionFont = fontDialog.Font;
            }
        }

      
       
    }
}
