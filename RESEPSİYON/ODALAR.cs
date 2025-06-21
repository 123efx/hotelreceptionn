using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace RESEPSİYON
{
    public partial class ODALAR : Form
    {
        public ODALAR()
        {
            InitializeComponent();
            Musteribilgiler();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GPJ6GJB\\SQLEXPRESS;Initial Catalog=RESEPSIYONBILGILER;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand komut;
        SqlDataAdapter dosya;

        void Musteribilgiler()
        {
            con.Open();
            komut = new SqlCommand("SELECT *FROM fiyattable", con);
            dosya = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            dosya.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fiyatKomut = new SqlCommand($"SELECT [deniz manzarali] FROM fiyattable", con);
            object fiyatObj = fiyatKomut.ExecuteScalar();
            con.Close();
            int fiyat = Convert.ToInt32(fiyatObj); 
            int kisisayisi=comboBox1.SelectedIndex;
            int sonuc = kisisayisi * fiyat;
            label1.Text = sonuc.ToString() + "€"; 
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fiyatKomut = new SqlCommand($"SELECT [bahceli] FROM fiyattable", con);
            object fiyatObj = fiyatKomut.ExecuteScalar();
            con.Close();
            int fiyat = Convert.ToInt32(fiyatObj);
            int kisisayisi = comboBox2.SelectedIndex;
            int sonuc = kisisayisi * fiyat;
            label2.Text = sonuc.ToString() + "€";
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fiyatKomut = new SqlCommand($"SELECT [swim] FROM fiyattable", con);
            object fiyatObj = fiyatKomut.ExecuteScalar();
            con.Close();
            int fiyat = Convert.ToInt32(fiyatObj);
            int kisisayisi = comboBox4.SelectedIndex;
            int sonuc = kisisayisi * fiyat;
            label4.Text = sonuc.ToString() + "€"; 
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fiyatKomut = new SqlCommand($"SELECT [aile] FROM fiyattable", con);
            object fiyatObj = fiyatKomut.ExecuteScalar();
            con.Close();
            int fiyat = Convert.ToInt32(fiyatObj);
            int kisisayisi = comboBox3.SelectedIndex;
            int sonuc = kisisayisi * fiyat;
            label3.Text = sonuc.ToString() + "€";
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand fiyatKomut = new SqlCommand($"SELECT [dublex] FROM fiyattable", con);
            object fiyatObj = fiyatKomut.ExecuteScalar();
            con.Close();
            int fiyat = Convert.ToInt32(fiyatObj);
            int kisisayisi = comboBox5.SelectedIndex;
            int sonuc = kisisayisi * fiyat;
            label5.Text = sonuc.ToString() + "€";
        }

        private void ıconButton6_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedColumnIndex = dataGridView1.SelectedCells[0].ColumnIndex;
                string selectedColumnName = dataGridView1.Columns[selectedColumnIndex].Name;

                int yeniFiyat = 0;
                if (int.TryParse(textBox1.Text, out yeniFiyat))
                {
                    string güncelle = $"UPDATE fiyattable SET [{selectedColumnName}] = @yeniFiyat";
                    komut = new SqlCommand(güncelle, con);
                    komut.Parameters.AddWithValue("@yeniFiyat", yeniFiyat);
                    con.Open();
                    komut.ExecuteNonQuery();
                    con.Close();
                    Musteribilgiler(); 
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir fiyat girin.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir sütun seçin.");
            } 
        }
    }
}
