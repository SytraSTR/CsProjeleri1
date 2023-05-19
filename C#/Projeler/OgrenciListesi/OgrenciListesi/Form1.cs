using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciListesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i = 0;
        int[] Ortalama = new int[10];
        string[] Ogrenci = new string[10];
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Ogrenci[i] = bunifuMaterialTextbox1.Text;
                Ortalama[i] = Convert.ToInt16(bunifuMaterialTextbox2.Text);
                i++;
                if (i == 10)
                {
                    MessageBox.Show("10 Adet Öğrenci Girilmiştir.");
                    bunifuMaterialTextbox1.Enabled = false;
                    bunifuMaterialTextbox2.Enabled = false;
                    bunifuThinButton21.Enabled = false;
                }
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox2.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata gerçekleşti; " + hata);
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Ortalama[i] != 0)
                {
                    listBox1.Items.Add(Ogrenci[i] + " " + Ortalama[i]);
                }
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Ortalama[i]<50)
                {
                    if (Ortalama[i] != 0)
                    {
                        listBox1.Items.Add(Ogrenci[i] + " " + Ortalama[i]);
                    }
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Ortalama[i] >= 50)
                {
                    if (Ortalama[i] != 0)
                    {
                        listBox1.Items.Add(Ogrenci[i] + " " + Ortalama[i]);
                    }
                }
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Ortalama[i] >= 70 && Ortalama[i] < 85)
                {
                    if (Ortalama[i] != 0)
                    {
                        listBox1.Items.Add(Ogrenci[i] + " " + Ortalama[i]);
                    }
                }
            }
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Ortalama[i] >= 85)
                {
                    if (Ortalama[i] != 0)
                    {
                        listBox1.Items.Add(Ogrenci[i] + " " + Ortalama[i]);
                    }
                }
            }
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
