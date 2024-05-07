using System.ComponentModel.DataAnnotations;

namespace FrizerskiSalonObjekti.FSObjekti
{
    public class Radnik
    {
        public Radnik() 
        {
            ID_Radnik = 0;
            Ime_Prezime = string.Empty;
        }
        public Radnik(int idRadnik, string ime_prezime)
        {
            ID_Radnik=idRadnik;
            Ime_Prezime=ime_prezime;
        }
        public int ID_Radnik { get; set; }
        public string Ime_Prezime { get; set; }
    }
}
