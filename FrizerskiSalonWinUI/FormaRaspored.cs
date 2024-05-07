using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrizerskiSalonWinUI
{
    public partial class FormaRaspored : Form
    {
        private Radnik _radnik = null;
        public FormaRaspored()
        {
            InitializeComponent();
        }
        public FormaRaspored(Radnik radnik, int dan, int mesec, int godina)
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(godina, mesec, dan);
            _radnik = radnik;
        }
        private async void btnSacuvajRaspored_Click(object sender, EventArgs e)
        {
            btnSacuvajRaspored.Enabled = false;
            await KreirajRaspored();
            MessageBox.Show("Raspored kreiran");
            this.Close();
        }

        private async Task KreirajRaspored()
        {
            var client = new HttpClient();
            try
            {
                var rasporedUnos = new NoviRaspored();
                rasporedUnos.Radnik = _radnik;
                rasporedUnos.Mesec = dateTimePicker1.Value.Month;
                rasporedUnos.Godina = dateTimePicker1.Value.Year;
                rasporedUnos.Prepodne = rButtonPrePodne.Checked;

                var jsonInString = JsonConvert.SerializeObject(rasporedUnos);

                var response = await client.PostAsync(FrizerskiSalonAPIURLs.noviRasporedRadnikaAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
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
