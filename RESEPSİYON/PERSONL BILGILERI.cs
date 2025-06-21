using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESEPSİYON
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("ISLEM BASARISIZ. LÜTFEN ODA NUMARASI GIRINIZ!");
                button1.ForeColor = Color.Red;
            }

            else
            {
                button1.ForeColor = Color.Green;
                textBox1.Text = "GÖNDERİLDİ..."; 
            }  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("ISLEM BASARISIZ. LÜTFEN ODA NUMARASI GIRINIZ!");
                button2.ForeColor = Color.Red;
            }

            else
            {
                button2.ForeColor = Color.Green;
                textBox2.Text = "GÖNDERİLDİ..."; 
            } 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("ISLEM BASARISIZ. LÜTFEN ODA NUMARASI GIRINIZ!");
                button3.ForeColor = Color.Red;
            }

            else
            {
                button3.ForeColor = Color.Green;
                textBox3.Text = "GÖNDERİLDİ...";
            }
        } 

            private void button4_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("ISLEM BASARISIZ. LÜTFEN ODA NUMARASI GIRINIZ!");
                button4.ForeColor = Color.Red;
            }

            else
            {
                button4.ForeColor = Color.Green;
                textBox4.Text = "GÖNDERİLDİ...";
            }
        }
    }
} 