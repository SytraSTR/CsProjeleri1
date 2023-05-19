using Bunifu.Framework.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bunifuThinButton220_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool Durum = false;
        double Sonuc = 0;
        string Islem = " ";
        private void Girdi(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "0" || Durum)
            {
                bunifuMaterialTextbox1.Text = "";
            }
            Durum = false;
            BunifuThinButton2 btn = (BunifuThinButton2)sender;
            bunifuMaterialTextbox1.Text += btn.ButtonText;
        }

        private void Islemler(object sender, EventArgs e)
        {
            Durum = true;
            BunifuThinButton2 islem = (BunifuThinButton2)sender;
            string yeniIslem = islem.ButtonText;
            bunifuCustomLabel1.Text = bunifuCustomLabel1.Text + " " + bunifuMaterialTextbox1.Text + " " + yeniIslem;
            switch (Islem)
            {
                case "+":
                    bunifuMaterialTextbox1.Text = (Sonuc + Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "-":
                    bunifuMaterialTextbox1.Text = (Sonuc - Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "*":
                    bunifuMaterialTextbox1.Text = (Sonuc * Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "/":
                    bunifuMaterialTextbox1.Text = (Sonuc / Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
            }
            Islem = yeniIslem;
            Sonuc = Convert.ToDouble(bunifuMaterialTextbox1.Text);
            bunifuMaterialTextbox1.Text = Sonuc.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton222_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "0";
            bunifuCustomLabel1.Text = "";
            Islem = "";
            Sonuc = 0;
            Durum = false;
        }

        private void bunifuThinButton223_Click(object sender, EventArgs e)
        {
            bunifuMaterialTextbox1.Text = "0";
        }

        private void bunifuThinButton221_Click(object sender, EventArgs e)
        {
            bunifuCustomLabel1.Text = "";
            switch (Islem)
            {
                case "+":
                    bunifuMaterialTextbox1.Text = (Sonuc + Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "-":
                    bunifuMaterialTextbox1.Text = (Sonuc - Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "*":
                    bunifuMaterialTextbox1.Text = (Sonuc * Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
                case "/":
                    bunifuMaterialTextbox1.Text = (Sonuc / Convert.ToDouble(bunifuMaterialTextbox1.Text)).ToString();
                    break;
            }
            Islem = " ";
            Sonuc = Convert.ToDouble(bunifuMaterialTextbox1.Text);
            bunifuMaterialTextbox1.Text = Sonuc.ToString();
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "0" || Durum)
            {
                bunifuMaterialTextbox1.Text = "0";
            }
            if (!bunifuMaterialTextbox1.Text.Contains(","))
            {
                bunifuMaterialTextbox1.Text += ",";
            }
            Durum = false;
        }

        private void bunifuThinButton213_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(bunifuMaterialTextbox1.Text) > 0)
            {
                bunifuMaterialTextbox1.Text = bunifuMaterialTextbox1.Text.Remove(bunifuMaterialTextbox1.Text.Length - 1, 1);
                if (bunifuMaterialTextbox1.Text.Length == 0)
                {
                    bunifuMaterialTextbox1.Text = "0";
                }
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            double kare = Convert.ToDouble(bunifuMaterialTextbox1.Text);
            kare = kare * kare;
            bunifuMaterialTextbox1.Text = Convert.ToString(kare);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            double kareKok = Convert.ToDouble(bunifuMaterialTextbox1.Text);
            kareKok = Math.Sqrt(kareKok);
            bunifuMaterialTextbox1.Text = Convert.ToString(kareKok);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            double Yuzde = Convert.ToDouble(bunifuMaterialTextbox1.Text) / 100;
            bunifuCustomLabel1.Text = bunifuMaterialTextbox1.Text + "%";
            bunifuMaterialTextbox1.Text = Convert.ToString(Yuzde);
        }
    }
}
