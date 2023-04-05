using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace CurrencyConverter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string APIKey = "bsSlFZvE4WokZlLKR3wEFmoH0pZBoSQssZxEQluI";

        private void btn_convert_Click(object sender, EventArgs e)
        {
            getConversion();
        }

        private void getConversion()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.freecurrencyapi.com/v1/latest?apikey={0}&currencies={1}&base_currency={2}", APIKey, tb_to_value.Text, tb_from_value.Text);

                var json = web.DownloadString(url);
                Currency.Root info = JsonConvert.DeserializeObject<Currency.Root>(json);
                double result = double.Parse(tb_amount_from_value.Text);
                double first_result = result;
                switch (tb_to_value.Text)
                {
                    case "AUD":
                        result = result * info.data.AUD;
                        break;
                    case "BGN":
                        result = result * info.data.BGN;
                        break;
                    case "BRL":
                        result = result * info.data.BRL;
                        break;
                    case "CAD":
                        result = result * info.data.CAD;
                        break;
                    case "CHF":
                        result = result * info.data.CHF;
                        break;
                    case "CNY":
                        result = result * info.data.CNY;
                        break;
                    case "CZK":
                        result = result * info.data.CZK;
                        break;
                    case "DKK":
                        result = result * info.data.DKK;
                        break;
                    case "EUR":
                        result = result * info.data.EUR;
                        break;
                    case "GBP":
                        result = result * info.data.GBP;
                        break;
                    case "HKD":
                        result = result * info.data.HKD;
                        break;
                    case "HUF":
                        result = result * info.data.HUF;
                        break;
                    case "IDR":
                        result = result * info.data.IDR;
                        break;
                    case "ILS":
                        result = result * info.data.ILS;
                        break;
                    case "INR":
                        result = result * info.data.INR;
                        break;
                    case "ISK":
                        result = result * info.data.ISK;
                        break;
                    case "JPY":
                        result = result * info.data.JPY;
                        break;
                    case "KRW":
                        result = result * info.data.KRW;
                        break;
                    case "MXN":
                        result = result * info.data.MXN;
                        break;
                    case "MYR":
                        result = result * info.data.MYR;
                        break;
                    case "NOK":
                        result = result * info.data.NOK;
                        break;
                    case "NZD":
                        result = result * info.data.NZD;
                        break;
                    case "PHP":
                        result = result * info.data.PHP;
                        break;
                    case "PLN":
                        result = result * info.data.PLN;
                        break;
                    case "RON":
                        result = result * info.data.RON;
                        break;
                    case "RUB":
                        result = result * info.data.RUB;
                        break;
                    case "SEK":
                        result = result * info.data.SEK;
                        break;
                    case "SGD":
                        result = result * info.data.SGD;
                        break;
                    case "THB":
                        result = result * info.data.THB;
                        break;
                    case "TRY":
                        result = result * info.data.TRY;
                        break;
                    case "USD":
                        result = result * info.data.USD;
                        break;
                    case "ZAR":
                        result = result * info.data.ZAR;
                        break;
                    default:
                        lab_amount_to_value.Text = "N/A";
                        break;
                }
                if (result == first_result)
                {
                    lab_amount_to_value.Text = "Same Currency!";
                } else
                {
                    lab_amount_to_value.Text = result.ToString();
                }
            }
        }

        private void tb_amount_from_value_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btn_convert_Click(this, new EventArgs());
            }
        }
    }
}
