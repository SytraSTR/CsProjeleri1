using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kutuphane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\kutuphaneDb.mdf;Integrated Security=True");
        public void Yenile()
        {
            connect.Open();
            SqlDataAdapter Da = new SqlDataAdapter("Select *FROM kutuphane", connect);
            DataTable Tablo = new DataTable();
            Da.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            connect.Close();
        }
        public void Sifirla()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            maskedTextBox1.Clear();
            checkBox1.Checked = false;
            checkBox1.Enabled = false;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
            checkBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stn = "";
                if (radioButton1.Checked == true)
                {
                    stn = textBox6.Text;
                }
                if (radioButton2.Checked == true)
                {
                    stn = "Emanet";
                }
                SqlCommand tekrar = new SqlCommand("SELECT count(*) from kutuphane where TC='" + textBox2.Text + "'AND KitapAdi='" + textBox3.Text + "'", connect);
                connect.Open();
                int sonuc = (int)tekrar.ExecuteScalar();
                connect.Close();
                if (sonuc == 0)
                {
                    if (radioButton1.Checked == true || radioButton2.Checked == true)
                    {
                        if (textBox1.Text != "" && textBox2.Text != "" && maskedTextBox1.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                        {
                            string ekle = "INSERT INTO kutuphane(TC,AdSoyad,Numara,KitapAdi,KitapYazari,KitapYayinevi,KitapFiyati,KitapIade) VALUES (@1,@2,@3,@4,@5,@6,@7,@8)";
                            SqlCommand command = new SqlCommand(ekle, connect);
                            command.Parameters.AddWithValue("@1", textBox2.Text);
                            command.Parameters.AddWithValue("@2", textBox1.Text);
                            command.Parameters.AddWithValue("@3", maskedTextBox1.Text);
                            command.Parameters.AddWithValue("@4", textBox3.Text);
                            command.Parameters.AddWithValue("@5", textBox4.Text);
                            command.Parameters.AddWithValue("@6", textBox5.Text);
                            command.Parameters.AddWithValue("@7", stn);
                            command.Parameters.AddWithValue("@8", " ");
                            connect.Open();
                            command.ExecuteNonQuery();
                            connect.Close();
                            Yenile();
                            MessageBox.Show("Kişi kaydedildi");
                        }
                        else
                        {
                            MessageBox.Show("Eksik Bilgi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Türü Seçmediniz");
                    }
                }
                else if (sonuc > 0)
                {
                    MessageBox.Show(textBox1.Text + " adlı kullanıcının zaten " + textBox3.Text + " kitabı var");
                }
                Sifirla();
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata; " + hata);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connect.Open();
            DataTable tablo = new DataTable();
            SqlDataAdapter Da = new SqlDataAdapter(" ", connect);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            string Iade = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            if (textBox6.Text != "")
            {
                checkBox1.Enabled = true;
                if (textBox6.Text == "Emanet")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
            }
            if (Iade == "Iade")
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Iade = "";
            if (checkBox1.Checked == true)
            {
                Iade = "Iade";
            }
            SqlCommand tekrar = new SqlCommand("SELECT count(*) from kutuphane where TC='" + textBox2.Text + "'AND KitapAdi='" + textBox3.Text + "'", connect);
            connect.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            connect.Close();
            if (sonuc > 0)
            {
                string Duzenle = "UPDATE kutuphane SET AdSoyad=@2,Numara=@3,KitapYazari=@5,KitapYayinevi=@6,KitapFiyati=@7,KitapIade=@8 WHERE TC=@1 AND KitapAdi=@4";
                SqlCommand command = new SqlCommand(Duzenle, connect);
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", textBox1.Text);
                command.Parameters.AddWithValue("@3", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@4", textBox3.Text);
                command.Parameters.AddWithValue("@5", textBox4.Text);
                command.Parameters.AddWithValue("@6", textBox5.Text);
                command.Parameters.AddWithValue("@7", textBox6.Text);
                command.Parameters.AddWithValue("@8", Iade);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                Yenile();
                MessageBox.Show("Düzenleme başarılı");
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            Sifirla();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand tekrar = new SqlCommand("SELECT count(*) from kutuphane where TC='" + textBox2.Text + "'AND KitapAdi='" + textBox3.Text + "'", connect);
            connect.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            connect.Close();
            if (sonuc > 0)
            {
                string sil = "DELETE FROM kutuphane WHERE TC=@1 AND KitapAdi=@2";
                SqlCommand command = new SqlCommand(sil, connect);
                command.Parameters.AddWithValue("@1", textBox2.Text);
                command.Parameters.AddWithValue("@2", textBox3.Text);
                connect.Open();
                command.ExecuteNonQuery();
                connect.Close();
                Yenile();
                MessageBox.Show("Kayıt Silindi");
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
            Sifirla();
        }
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Sifirla();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            connect.Open();
            string Ara = "Select id from kutuphane where TC=@1 and KitapAdi=@2";
            SqlCommand command = new SqlCommand(Ara, connect);
            command.Parameters.AddWithValue("@1", textBox2.Text);
            command.Parameters.AddWithValue("@2", textBox3.Text);
            int result = command.ExecuteNonQuery();
            using (SqlDataReader reader = command.ExecuteReader())
            {
                
            }
            connect.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox6.Enabled = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            string iade = " ";
            connect.Open();
            string Ara = "SELECT * from kutuphane where TC=@1 AND KitapAdi=@2";
            SqlCommand komut = new SqlCommand(Ara, connect);
            komut.Parameters.AddWithValue("@1", textBox2.Text);
            komut.Parameters.AddWithValue("@2", textBox3.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox2.Text = dr["TC"].ToString();
                textBox1.Text = dr["AdSoyad"].ToString();
                maskedTextBox1.Text = dr["Numara"].ToString();
                textBox3.Text = dr["KitapAdi"].ToString();
                textBox4.Text = dr["KitapYazari"].ToString();
                textBox5.Text = dr["KitapYayinevi"].ToString();
                textBox6.Text = dr["KitapFiyati"].ToString();
                iade = dr["Iade"].ToString();
                checkBox1.Enabled = true;
                if (textBox6.Text == "Emanet")
                {
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton1.Checked = true;
                }
                if (iade == "Iade")
                {
                    checkBox1.Checked = true;
                }
                else
                {
                    checkBox1.Checked = false;
                }
                Yenile();
            }
            else
            {
                MessageBox.Show("Müşteri Bulunamadı.");
            }
            connect.Close();
        }
    }
}

