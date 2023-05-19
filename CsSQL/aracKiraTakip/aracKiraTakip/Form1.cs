using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace aracKiraTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Connect = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\araclar.mdf;Integrated Security=True");
        public void Yenile()
        {
            Connect.Open();
            SqlDataAdapter Da = new SqlDataAdapter("Select *FROM araclar", Connect);
            DataTable Tablo = new DataTable();
            Da.Fill(Tablo);
            dataGridView1.DataSource = Tablo;
            Connect.Close();
        }
        public void Sifirla()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            comboBox1.Text = "";
            comboBox2.Text="";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Yenile();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand tekrar = new SqlCommand("SELECT count(*) from araclar where Plaka='" + textBox1.Text  + "'", Connect);
                Connect.Open();
                int sonuc = (int)tekrar.ExecuteScalar();
                Connect.Close();
                if (sonuc == 0)
                {
                    if (comboBox1.Text!="")
                    {
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text !=""&&comboBox2.Text!="")
                        {
                            string ekle = "INSERT INTO araclar(Plaka,Marka,Model,UretimYili,KM,Renk,YakitTuru,KiraUcreti,Durum) VALUES (@1,@2,@3,@4,@5,@6,@7,@8,@9)";
                            SqlCommand command = new SqlCommand(ekle, Connect);
                            command.Parameters.AddWithValue("@1", textBox1.Text);
                            command.Parameters.AddWithValue("@2", textBox2.Text);
                            command.Parameters.AddWithValue("@3", textBox3.Text);
                            command.Parameters.AddWithValue("@4", textBox4.Text);
                            command.Parameters.AddWithValue("@5", textBox5.Text);
                            command.Parameters.AddWithValue("@6", textBox6.Text);
                            command.Parameters.AddWithValue("@7", comboBox1.Text);
                            command.Parameters.AddWithValue("@8", textBox7.Text);
                            command.Parameters.AddWithValue("@9", comboBox2.Text);
                            Connect.Open();
                            command.ExecuteNonQuery();
                            Connect.Close();
                            Yenile();
                            Sifirla();
                            MessageBox.Show("Kaydedildi");
                        }
                        else
                        {
                            MessageBox.Show("Eksik Bilgi");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Eksik Bilgi");
                    }
                }
                else if (sonuc > 0)
                {
                    MessageBox.Show(textBox1.Text + " plakalı araç zaten kayıtlı");
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hata; " + hata);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connect.Open();
            string Ara = "SELECT * from araclar where Plaka=@1";
            SqlCommand komut = new SqlCommand(Ara, Connect);
            komut.Parameters.AddWithValue("@1", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr["Plaka"].ToString();
                textBox2.Text = dr["Marka"].ToString();
                textBox3.Text = dr["Model"].ToString();
                textBox4.Text = dr["UretimYili"].ToString();
                textBox5.Text = dr["KM"].ToString();
                textBox6.Text = dr["Renk"].ToString();
                comboBox1.Text = dr["YakitTuru"].ToString();
                textBox7.Text = dr["KiraUcreti"].ToString();
                comboBox2.Text = dr["Durum"].ToString();
            }
            else
            {
                MessageBox.Show("Müşteri Bulunamadı.");
            }
            Connect.Close();
            Yenile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand tekrar = new SqlCommand("SELECT count(*) from araclar where Plaka='" + textBox1.Text + "'", Connect);
            Connect.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            Connect.Close();
            if (sonuc > 0)
            {
                string Duzenle = "UPDATE araclar SET Marka=@2,Model=@3,UretimYili=@4,KM=@5,Renk=@6,YakitTuru=@7,KiraUcreti= @8,Durum=@9 WHERE Plaka=@1";
                SqlCommand command = new SqlCommand(Duzenle, Connect);
                command.Parameters.AddWithValue("@1", textBox1.Text);
                command.Parameters.AddWithValue("@2", textBox2.Text);
                command.Parameters.AddWithValue("@3", textBox3.Text);
                command.Parameters.AddWithValue("@4", textBox4.Text);
                command.Parameters.AddWithValue("@5", textBox5.Text);
                command.Parameters.AddWithValue("@6", textBox6.Text);
                command.Parameters.AddWithValue("@7", comboBox1.Text);
                command.Parameters.AddWithValue("@8", textBox7.Text);
                command.Parameters.AddWithValue("@9", comboBox2.Text);
                Connect.Open();
                command.ExecuteNonQuery();
                Connect.Close();
                Yenile();
                Sifirla();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand tekrar = new SqlCommand("SELECT count(*) from araclar where Plaka='" + textBox1.Text + "'", Connect);
            Connect.Open();
            int sonuc = (int)tekrar.ExecuteScalar();
            Connect.Close();
            if (sonuc > 0)
            {
                string sil = "DELETE FROM araclar WHERE Plaka=@1";
                SqlCommand command = new SqlCommand(sil, Connect);
                command.Parameters.AddWithValue("@1", textBox1.Text);
                Connect.Open();
                command.ExecuteNonQuery();
                Connect.Close();
                Yenile();
                Sifirla();
            }
            else
            {
                MessageBox.Show("Kayıt Bulunamadı");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            comboBox1.Text= dataGridView1.CurrentRow.Cells[7].Value.ToString();
            textBox7.Text= dataGridView1.CurrentRow.Cells[8].Value.ToString();
            comboBox2.Text= dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Sifirla();
        }
    }
}
