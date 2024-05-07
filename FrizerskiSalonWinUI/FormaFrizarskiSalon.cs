using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.VisualBasic;
using Newtonsoft.Json;
using System.Linq;
using System.Text;

namespace FrizerskiSalonWinUI
{
    public partial class FormaFrizarskiSalon : Form
    {
        public FormaFrizarskiSalon()
        {
            InitializeComponent();
            UcitajRadnike();
            SrediPrikaz();

            tabPageUsluge.Enter += TabPageUsluge_Enter;
            dGridUsluge.SelectionChanged += dGridUsluge_SelectionChanged;
        }

        private void SrediPrikaz()
        {
            #region radnici prikaz

            dGridRadnici.SelectionChanged += dGridRadnici_SelectionChanged;

            #endregion

            #region radnik kalendar prikaz

            int sat = 6;
            int min = 0;
            for (int i = 0; i < 57; i++)
            {
                dGridRadnikKaledar.Rows.Add(new DataGridViewRow());
                dGridRadnikKaledar.Rows[i].Height = 16;

                if (i % 4 == 0)
                {
                    sat++;
                    min = 0;
                }
                else
                    min += 15;

                var strSat = sat < 10 ? "0" + sat.ToString() : sat.ToString();
                var strMin = min == 0 ? "00" : min.ToString();

                dGridRadnikKaledar.Rows[i].HeaderCell.Value = $"{strSat}:{strMin}";
                dGridRadnikKaledar.Rows[i].HeaderCell.Tag = TimeOnly.ParseExact($"{strSat}:{strMin}", "HH:mm");

            }

            #endregion

            #region selekcija datuma
            dTimeIzborDatuma.ValueChanged += dTimeIzborDatuma_ValueChanged;
            dTimeIzborDatuma_ValueChanged(dTimeIzborDatuma, new EventArgs());
            #endregion
        }
        private void btnDodajRadnika_Click(object sender, EventArgs e)
        {
            var noviRadnik = new FormaNoviRadnik();
            noviRadnik.ShowDialog(this);
            UcitajRadnike();
        }
        private void dTimeIzborDatuma_ValueChanged(object? sender, EventArgs e)
        {

            #region sredi datume u prikazu za izabranu datum u nedelji
            DateOnly datum = DateOnly.FromDateTime(dTimeIzborDatuma.Value);
            var razlikaUNazad = datum.DayOfWeek - DayOfWeek.Monday;
            var polazniDatumZaPonedeljak = datum.AddDays(-razlikaUNazad);
            for (var i = 0; i < 6; i++)
            {
                DateOnly sledeciDan = polazniDatumZaPonedeljak.AddDays(i);
                dGridRadnikKaledar.Columns[i].HeaderText = $"{sledeciDan.DayOfWeek} - {sledeciDan.Day}.{sledeciDan.Month}"; //TODO: Mogla bih da prevedem ove engl nazive ! Bljak :(
                dGridRadnikKaledar.Columns[i].Tag = sledeciDan;
            }
            #endregion

            #region popuni radno vreme
            if (dGridRadnici.SelectedRows.Count > 0)
            {
                UcitajKalendarZaRadnika(new Radnik((int)dGridRadnici.SelectedRows[0].Cells[0].Value, (string)dGridRadnici.SelectedRows[0].Cells[1].Value));
            }
            #endregion
        }
        private void dGridRadnici_SelectionChanged(object? sender, EventArgs e)
        {
            if (dGridRadnici.SelectedRows.Count == 0)
                return;

            var selectedRow = dGridRadnici.SelectedRows[0];
            UcitajKalendarZaRadnika(new Radnik((int)selectedRow.Cells[0].Value, (string)selectedRow.Cells[1].Value));
        }
        private async void UcitajRadnike()
        {
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(FrizerskiSalonAPIURLs.sviRadniciAPI);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                List<Radnik> radnici = JsonConvert.DeserializeObject<List<Radnik>>(content);
                dGridRadnici.DataSource = radnici;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void UcitajKalendarZaRadnika(Radnik radnik)
        {
            foreach (DataGridViewColumn col in dGridRadnikKaledar.Columns)
            {
                //if(col.Index == 0)
                //    continue;
                foreach (DataGridViewRow row in dGridRadnikKaledar.Rows)
                {
                    row.Cells[col.Index].Style.BackColor = Color.White;
                }
            }

            var client = new HttpClient();
            try
            {
                var jsonInString = JsonConvert.SerializeObject(radnik);
                var response = await client.PostAsync(FrizerskiSalonAPIURLs.radnoVremeRadnikaAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                List<RadnoVreme> radnaVremena = JsonConvert.DeserializeObject<List<RadnoVreme>>(content);

                foreach (var rv in radnaVremena)
                {
                    foreach (DataGridViewColumn col in dGridRadnikKaledar.Columns)
                    {
                        if (col.Tag != null && (DateOnly)col.Tag == rv.Datum)
                        {
                            var colIndex = col.Index;
                            foreach (DataGridViewRow row in dGridRadnikKaledar.Rows)
                            {
                                if ((TimeOnly)row.HeaderCell.Tag >= rv.Vreme_Od && ((TimeOnly)row.HeaderCell.Tag) <= rv.Vreme_Do)
                                    row.Cells[colIndex].Style.BackColor = Color.DarkSeaGreen;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private async void UcitajUsluge()
        {
            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(FrizerskiSalonAPIURLs.sveUslugeAPI);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                List<Usluga> usluge = JsonConvert.DeserializeObject<List<Usluga>>(content);
                dGridUsluge.DataSource = usluge;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void dGridUsluge_SelectionChanged(object? sender, EventArgs e)
        {
            if (dGridUsluge.SelectedRows.Count == 0)
                return;
            var selectedRow = dGridUsluge.SelectedRows[0];
            UcitajTretmane(new Usluga((int)selectedRow.Cells[0].Value, (string)selectedRow.Cells[1].Value, (int)selectedRow.Cells[2].Value, (decimal)selectedRow.Cells[3].Value));
        }
        private async void UcitajTretmane(Usluga usluga)
        {
            chListRadnici.ClearSelected();
            ((ListBox)chListRadnici).DataSource = null;
            chListRadnici.Items.Clear();

            var sviRadnici = new List<Radnik>();
            var tretmaniZaUslugu = new List<Radnik>();

            var client = new HttpClient();
            try
            {
                var response = await client.GetAsync(FrizerskiSalonAPIURLs.sviRadniciAPI);
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                sviRadnici = JsonConvert.DeserializeObject<List<Radnik>>(content);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            try
            {
                var jsonInString = JsonConvert.SerializeObject(usluga);
                var response = await client.PostAsync(FrizerskiSalonAPIURLs.sviRadniciZaUsluguAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                tretmaniZaUslugu = JsonConvert.DeserializeObject<List<Radnik>>(content);
            }
            catch (Exception ex)
            {
                throw ex;
            }


            ((ListBox)chListRadnici).DataSource = sviRadnici;
            ((ListBox)chListRadnici).DisplayMember = "Ime_Prezime";
            for (int i = 0; i < chListRadnici.Items.Count; i++)
            {
                var item = chListRadnici.Items[i];
                if (tretmaniZaUslugu.Select(x => x.ID_Radnik).ToList().Contains(((Radnik)item).ID_Radnik))
                {
                    chListRadnici.SetItemChecked(i, true);
                }
            }

        }
        private void TabPageUsluge_Enter(object? sender, EventArgs e)
        {
            UcitajUsluge();
        }
        private void btnDodajUsluga_Click(object sender, EventArgs e)
        {
            var novaUsluga = new FormaNovaUsluga();
            novaUsluga.ShowDialog(this);
            UcitajUsluge();
        }
        private void btnRadnikRaspored_Click(object sender, EventArgs e)
        {
            var selectedRow = dGridRadnici.SelectedRows[0];
            var radnik = new Radnik((int)selectedRow.Cells[0].Value, (string)selectedRow.Cells[1].Value);

            var izabranMesec = dTimeIzborDatuma.Value.Month;
            var izabranaGodina = dTimeIzborDatuma.Value.Year;
            var raspored = new FormaRaspored(radnik, 1, dTimeIzborDatuma.Value.Month, dTimeIzborDatuma.Value.Year);
            raspored.ShowDialog(this);
        }
        private async void btnUslugaRadniciSacuvaj_Click(object sender, EventArgs e)
        {
            await SnimiUlsugaRadnici();
            MessageBox.Show("Tretmani za uslugu uspesno sacuvani");
        }
        private async Task SnimiUlsugaRadnici()
        {
            if (dGridUsluge.SelectedRows.Count == 0)
                return;
            var selectedRow = dGridUsluge.SelectedRows[0];
            var usluga = new Usluga((int)selectedRow.Cells[0].Value, (string)selectedRow.Cells[1].Value, (int)selectedRow.Cells[2].Value, (decimal)selectedRow.Cells[3].Value);
            var tretmani = new List<Tretman>();
            foreach (var item in chListRadnici.CheckedItems)
            {
                tretmani.Add(new Tretman(0, usluga, (Radnik)item));
            }

            var jsonInString = JsonConvert.SerializeObject(tretmani);
            var client = new HttpClient();
            var response = await client.PostAsync(FrizerskiSalonAPIURLs.snimiUlsugaRadnikAPI, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
        }

        private void mockButton_Click(object sender, EventArgs e)
        {
            ProveriZakazivanje();
        }
        private async void ProveriZakazivanje()
        {
            var client = new HttpClient();
            try
            {
                var zakazivanjeZahtev = new ZakazivanjeZahtev();
                zakazivanjeZahtev.Usluge.Add(new Usluga(1, "Zensko friziranje", 60, 4500.00M)); // 60min
                zakazivanjeZahtev.Usluge.Add(new Usluga(5, "Farbanje", 45, 3600.00M)); // 60min
                zakazivanjeZahtev.Usluge.Add(new Usluga(6, "Nokti", 15, 200.00M)); // 60min
                zakazivanjeZahtev.Usluge.Add(new Usluga(7, "Pranje kose", 15, 600.00M)); // 60min
                zakazivanjeZahtev.Datum = new DateOnly(2024, 5, 1);
                zakazivanjeZahtev.Prepodne = true;
                var jsonInString = JsonConvert.SerializeObject(zakazivanjeZahtev);
                var response = await client.PostAsync(FrizerskiSalonAPIURLs.pronadjiTerminZaZahtev, new StringContent(jsonInString, Encoding.UTF8, "application/json"));
                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();
                //List<RadnoVreme> radnaVremena = JsonConvert.DeserializeObject<List<RadnoVreme>>(content);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
