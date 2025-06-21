using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp; 

namespace RESEPSİYON
{
    public partial class MAINMENU : Form
    {
        public MAINMENU()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        private void ıconButton3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.MdiParent = this;
            form5.Show(); 
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.MdiParent = this;
            form3.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ıconButton2_Click(object sender, EventArgs e)
        {
            ODALAR form4 = new ODALAR();
            form4.MdiParent = this;
            form4.Show();
        }

        private void ıconButton4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.MdiParent = this;
            form6.Show();
        }

        private void ıconButton5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.MdiParent = this;
            form7.Show(); 
        }
    }
}
