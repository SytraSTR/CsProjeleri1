using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        bool Durum = false;
        double Sonuc = 0;
        string Islem = " ";
        public Form1()
        {
            InitializeComponent();
        }

        private void Rakam(object sender, EventArgs e)
        {
            if (textBox1.Text=="0"||Durum)
            {
                textBox1.Clear();
            }
            Durum = false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }

        private void Islemler(object sender, EventArgs e)
        {
            Durum = true;
            Button islem = (Button)sender;
            string yeniIslem = islem.Text;
            label1.Text = label1.Text + " " + textBox1.Text + " " + yeniIslem;
            switch (Islem)
            {
                case "+":
                    textBox1.Text = (Sonuc + Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "-":
                    textBox1.Text = (Sonuc - Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "*":
                    textBox1.Text = (Sonuc * Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "/":
                    textBox1.Text = (Sonuc / Convert.ToDouble(textBox1.Text)).ToString();
                break;
            }
            Islem = yeniIslem;
            Sonuc = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Sonuc.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            Islem = "";
            Sonuc = 0;
            Durum = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            switch (Islem)
            {
                case "+":
                    textBox1.Text = (Sonuc + Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "-":
                    textBox1.Text = (Sonuc - Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "*":
                    textBox1.Text = (Sonuc * Convert.ToDouble(textBox1.Text)).ToString();
                break;
                case "/":
                    textBox1.Text = (Sonuc / Convert.ToDouble(textBox1.Text)).ToString();
                break;
            }
            Islem = " ";
            Sonuc = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Sonuc.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0"||Durum)
            {
                textBox1.Text = "0";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
            Durum = false;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textBox1.Text)>0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                if (textBox1.Text.Length==0)
                {
                    textBox1.Text = "0";
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(textBox1.Text);
            kare = kare * kare;
            textBox1.Text = Convert.ToString(kare);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double kareKok = Convert.ToDouble(textBox1.Text);
            kareKok = Math.Sqrt(kareKok);
            textBox1.Text = Convert.ToString(kareKok);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            double Yuzde = Convert.ToDouble(textBox1.Text)/100; 
            label1.Text = textBox1.Text+"%";
            textBox1.Text = Convert.ToString(Yuzde);
        }
    }
}
