namespace RESEPSİYON
{
    public partial class GIRIS : Form
    {
        public GIRIS()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.MaxLength = 12; 
            textBox2.MaxLength = 9;
            textBox2.PasswordChar = '*';
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }


        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            CLISANLAR cli = new CLISANLAR();
            cli.ISIM = "EfeYagizDayi";
            cli.KOD = 123456789; 

            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("Lütfen karakter giriniz!");
            }

            if ((textBox1.Text == cli.ISIM) && (textBox2.Text == cli.KOD.ToString()))
            {
                MAINMENU form2 = new MAINMENU();
                form2.ShowDialog();
                this.Close(); 
            }

            else
            {
                MessageBox.Show("Giris Yapilamadi.");
                textBox1.Text = "";
                textBox2.Text = ""; 
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
