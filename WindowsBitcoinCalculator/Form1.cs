using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsBitcoinCalculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) {
        }


        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void textBox2_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
             if (ValiValuuta.SelectedItem.ToString() == "EUR")
              {
                  tulemus.Visible = true;
                  label2.Visible = true;
                  BitcoinRates newbitcoinrate = GetRates();
                  float result = float.Parse(box2.Text) * (float)newbitcoinrate.bpi.EUR.rate_float;
                  tulemus.Text = $"{result} Bitcoini {newbitcoinrate.bpi.EUR.code}";
                }     

            if (ValiValuuta.SelectedItem.ToString() == "GBP")
            {
                button1.Visible = true;
                label2.Visible = true;
                BitcoinRates newbitcoinrate = GetRates();
                float result = float.Parse(box2.Text) * (float)newbitcoinrate.bpi.EUR.rate_float;
                tulemus.Text = $"{result} Bitcoini {newbitcoinrate.bpi.EUR.code}";
            }

            if (ValiValuuta.SelectedItem.ToString() == "EEK")
            {
                button1.Visible = true;
                label2.Visible = true;

                float bitcoinAmount = float.Parse(box2.Text);
                BitcoinRates newbitcoinrate = GetRates();
                float eurAmount = bitcoinAmount * (float)newbitcoinrate.bpi.EUR.rate_float;
                const double eurToEekRate = 15.6466;
                double eekAmount = eurAmount * eurToEekRate;

                tulemus.Text = $"{eekAmount} EEK";
            }
        }


        public static BitcoinRates GetRates()
            {
                string url = "https://api.coindesk.com/v1/bpi/currentprice.json";
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "GET";

                var webResponse = request.GetResponse();
                var webStream = webResponse.GetResponseStream();

                BitcoinRates bitcoin;
                using (var responseReader = new StreamReader(webStream))
                {
                    var data = responseReader.ReadToEnd();
                    bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
                } return bitcoin;

            }
        }
    }


    
