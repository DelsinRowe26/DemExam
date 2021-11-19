using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (Catalog.SelectedIndex)
            {
                case 0:
                    {
                        tCtype.SelectTab(1);
                        break;
                    }
                case 1:
                    {
                        tCtype.SelectTab(3);
                        break;
                    }
                case 2:
                    {
                        tCtype.SelectTab(2);
                        break;
                    }
            }
        }

        private void Adres_Click(object sender, EventArgs e)
        {

        }

        private void tP0_Click(object sender, EventArgs e)
        {

        }

        private void tPhO_Click(object sender, EventArgs e)
        {

        }

        private void tPgR_Click(object sender, EventArgs e)
        {

        }

        private void tPaP_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            switch (City_Catolog.SelectedIndex)
            {
                case 0:
                    {
                        tCtype.SelectTab(1);
                        break;
                    }
                case 1:
                    {
                        tCtype.SelectTab(3);
                        break;
                    }
                case 2:
                    {
                        tCtype.SelectTab(2);
                        break;
                    }
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            // получаем выбранный файл
            string filename = saveFileDialog1.FileName;
            // сохраняем текст в файл
            System.IO.File.WriteAllText(filename, Catalog.Text +"\n"+ City_Catolog.Text + "\n" + tBsTr.Text + "\n" + tBnHm.Text + "\n" + TbNumRoom.Text + "\n" + tBlong.Text + "\n" + tBlati.Text + "\n" + tBnUmFl.Text + "\n"+ tBnUmRo.Text + "\n"+ textBox2.Text + "\n"+ tBsQ.Text + "\n" + tBnUmFlOr.Text + "\n"+ tBnUmRoO.Text + "\n" + tBsQuArE.Text);
            MessageBox.Show("Файл сохранен");
        }
    }
}
