using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RESEPSİYON
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox9.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox20.ReadOnly = true;
            textBox21.ReadOnly = true;
            textBox17.ReadOnly = true;
            textBox18.ReadOnly = true;
            textBox32.ReadOnly = true;
            textBox33.ReadOnly = true;
            textBox29.ReadOnly = true;
            textBox30.ReadOnly = true;
            textBox26.ReadOnly = true;
            textBox27.ReadOnly = true;
            textBox14.ReadOnly = true;
            textBox15.ReadOnly = true;
            textBox23.ReadOnly = true;
            textBox24.ReadOnly = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox5.BackColor = Color.Red;
                textBox6.BackColor = Color.Red;
            }
            else
            {
                textBox5.BackColor = Color.Green;
                textBox6.BackColor = Color.Green;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                textBox8.BackColor = Color.Red;
                textBox9.BackColor = Color.Red;
            }
            else
            {
                textBox8.BackColor = Color.Green;
                textBox9.BackColor = Color.Green;        
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                textBox14.BackColor = Color.Red;
                textBox15.BackColor = Color.Red;
            }
            else
            {
                textBox14.BackColor = Color.Green;
                textBox15.BackColor = Color.Green;   
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                textBox11.BackColor = Color.Red;
                textBox12.BackColor = Color.Red;
            }
            else
            {
                textBox11.BackColor = Color.Green;
                textBox12.BackColor = Color.Green;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                textBox26.BackColor = Color.Red;
                textBox27.BackColor = Color.Red;
            }
            else
            {
                textBox26.BackColor = Color.Green;
                textBox27.BackColor = Color.Green;
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked) 
            {
                textBox24.BackColor = Color.Red;
                textBox23.BackColor = Color.Red;
            }
            else
            {
                textBox24.BackColor = Color.Green;
                textBox23.BackColor = Color.Green;
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                textBox20.BackColor = Color.Red;
                textBox21.BackColor = Color.Red;
            }
            else
            {
                textBox20.BackColor = Color.Green;
                textBox21.BackColor = Color.Green;
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                textBox17.BackColor = Color.Red;
                textBox18.BackColor = Color.Red;
            }
            else
            {
                textBox17.BackColor = Color.Green;
                textBox18.BackColor = Color.Green;
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                textBox32.BackColor = Color.Red;
                textBox33.BackColor = Color.Red;
            }
            else
            {
                textBox32.BackColor = Color.Green;
                textBox33.BackColor = Color.Green;
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                textBox30.BackColor = Color.Red;
                textBox29.BackColor = Color.Red;
            }
            else
            {
                textBox30.BackColor = Color.Green;
                textBox29.BackColor = Color.Green;
            }
        }
    }
}
