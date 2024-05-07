using FrizerskiSalonObjekti.FSObjekti;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrizerskiSalonWinUI
{
    public partial class FormaNovaUsluga : Form
    {
        public FormaNovaUsluga()
        {
            InitializeComponent();
        }

        private async void btnUslugaSave_Click(object sender, EventArgs e)
        {
            await DodajUslugu();
            this.Close();
        }

        private async Task DodajUslugu()
        {
            var client = new HttpClient();
            try
            {
                var usluga = new Usluga(0, tBoxUslugaNaziv.Text, Int32.Parse(tBoxUslugaTrajanje.Text), Decimal.Parse(tBoxUslugaCena.Text));
                var jsonInString = JsonConvert.SerializeObject(usluga);
                var response = await client.PostAsync(FrizerskiSalonAPIURLs.novaUslugaAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return;
        }
    }
}
