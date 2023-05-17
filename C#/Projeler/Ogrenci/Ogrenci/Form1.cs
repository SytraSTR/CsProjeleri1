using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ogrenci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Ogrenci = new string[10];
        int[] Notlar = new int[10];
        int index = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Ogrenci[index] = textBox1.Text;
            Notlar[index] = Int16.Parse(textBox2.Text);
            index++;
            if (index==10)
            {
                MessageBox.Show("10 Adet öğrenci girilmiştir.");
                button1.Enabled= false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                listBox1.Items.Add(Ogrenci[i]+" " + Notlar[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Notlar[i]<50)
                {
                    listBox1.Items.Add(Ogrenci[i] + " " + Notlar[i]);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Notlar[i] >= 50)
                {
                    listBox1.Items.Add(Ogrenci[i] + " " + Notlar[i]);
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Notlar[i] >= 70 && Notlar[i] < 85)
                {
                    listBox1.Items.Add(Ogrenci[i] + " " + Notlar[i]);
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < Ogrenci.Length; i++)
            {
                if (Notlar[i] >= 85)
                {
                    listBox1.Items.Add(Ogrenci[i] + " " + Notlar[i]);
                }
            }
        }
    }
}
