using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Net;
using Newtonsoft.Json.Linq; 

namespace RESEPSİYON
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Start();
        }

        void havadurumu()
        {
             string api = "e31b4632cdedc17729a3543702e59f60";
            double lat = 36.8969;
            double lon = 30.7133;
            string apiUrl = $"https://api.openweathermap.org/data/2.5/weather?lat={lat}&lon={lon}&appid={api}";

            try
            {
                WebClient istemci = new WebClient();
                string jsonIcerik = istemci.DownloadString(apiUrl);

                dynamic data = JObject.Parse(jsonIcerik);

                var derece = data.main.temp;
                var dereceC= derece - 273.15;  
                var durum = data.weather[0].description;

                label2.Text = $"{dereceC} °C"; 
                label3.Text = durum;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata: {ex.Message}");
            }
        }  

        private void Form3_Load(object sender, EventArgs e)
        {
            havadurumu(); 
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss"); 
        }
    }
}
