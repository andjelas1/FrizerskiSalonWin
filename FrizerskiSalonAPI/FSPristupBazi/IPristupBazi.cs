using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;

namespace FrizerskiSalonAPI.FSPristupBazi
{
    public interface IPristupBazi
    {
        public IEnumerable<Radnik> UcitajRadnike();
        public Radnik UcitajRadnika(int idRadnik);
        public void KreirajRadnika(Radnik radnik);
        public IEnumerable<RadnoVreme> UcitajRadnoVremeRadnika(Radnik radnik);
        public void KreirajRasporedZaRadnika(Radnik radnik, int mesec, int godina, bool prepodne);
        public IEnumerable<Usluga> UcitajSveUsluge();
        public void KreirajUslugu(Usluga usluga);

        public IEnumerable<Radnik> UcitajRadnikeZaUslugu(Usluga usluga);

        public void SacuvajTretmane(List<Tretman> tretmani);

        public IEnumerable<Zakazivanje> PronadjiTermin(ZakazivanjeZahtev zahtev);
    }
}
