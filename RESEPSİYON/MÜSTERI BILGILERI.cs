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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-GPJ6GJB\\SQLEXPRESS;Initial Catalog=RESEPSIYONBILGILER;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand komut;
        SqlDataAdapter dosya;

        void Musteribilgiler()
        {
            con.Open();
            komut = new SqlCommand("SELECT *FROM bilgilerarac", con);
            dosya = new SqlDataAdapter(komut);
            DataTable tablo = new DataTable();
            dosya.Fill(tablo);
            dataGridView1.DataSource = tablo;
            con.Close(); 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells["Müsteri isim"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["müsteri oda"].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells["müsteri kalacagı gün sayisi"].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells["müsteri oda numarasi"].Value.ToString();
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            string ekle = "INSERT INTO resepsiyonbilgiler([Müsteri isim], [müsteri oda], [müsteri kalacagı gün sayisi], [müsteri oda numarasi]) VALUES(@MusteriIsim, @MusteriOda, @MusteriKalacagıGunSayisi, @MusteriOdaNo)";
            komut = new SqlCommand(ekle, con);
            komut.Parameters.AddWithValue("@MusteriIsim", textBox1.Text);
            komut.Parameters.AddWithValue("@MusteriOda", textBox2.Text);
            komut.Parameters.AddWithValue("@MusteriKalacagıGunSayisi", textBox3.Text);
            komut.Parameters.AddWithValue("@MusteriOdaNo", textBox4.Text);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            Musteribilgiler();
        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            string sil = "DELETE FROM resepsiyonbilgiler WHERE [Müsteri isim]=@MusteriIsim";
            komut = new SqlCommand(sil, con);
            komut.Parameters.AddWithValue("@MusteriIsim", textBox1.Text);
            con.Open();
            komut.ExecuteNonQuery();
            con.Close();
            Musteribilgiler(); 
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Musteribilgiler(); 
        }
    }
}
