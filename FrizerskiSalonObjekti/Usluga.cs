namespace FrizerskiSalonObjekti.FSObjekti
{
    public class Usluga
    {
        public Usluga()
        {
            ID_Usluga = 0;
            Naziv = string.Empty;
            Trajanje = 0;
            Cena = 0.0M;
        }
        public Usluga(int id, string naziv, int trajanje, decimal cena)
        {
            ID_Usluga = id;
            Naziv = naziv;
            Trajanje = trajanje;
            Cena = cena;
        }

        public int ID_Usluga { get; set; }
        public string Naziv {  get; set; }
        public int Trajanje {  get; set; }
        public decimal Cena { get; set; }
    }
}
