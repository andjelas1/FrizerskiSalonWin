using FrizerskiSalonObjekti.FSObjekti;
using Newtonsoft.Json;
using System.Text;

namespace FrizerskiSalonWinUI
{
    public partial class FormaNoviRadnik : Form
    {
        public FormaNoviRadnik()
        {
            InitializeComponent();
        }

        private async void btnRadnikSave_Click(object sender, EventArgs e)
        {
            await DodajRadnika();
            this.Close();
        }

        private async Task DodajRadnika()
        {
            var client = new HttpClient();
            try
            {
                var radnik = new Radnik(0, textBox1.Text);
                var jsonInString = JsonConvert.SerializeObject(radnik);
                var response = await client.PostAsync(FrizerskiSalonAPIURLs.noviRadnikAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
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
