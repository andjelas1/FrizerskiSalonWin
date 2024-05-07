namespace FrizerskiSalonObjekti.FSObjekti
{
    public class Musterija
    {
        public Musterija()
        {
            ID_Musterija = 0;
            Ime_prezime = string.Empty;
            Telefon = "/";
        }
        public int ID_Musterija {  get; set; }
        public string Ime_prezime { get; set; }
        public string Telefon {  get; set; }
    }
}
