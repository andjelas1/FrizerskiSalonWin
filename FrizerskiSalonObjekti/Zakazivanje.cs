using FrizerskiSalonObjekti.FSObjekti;

namespace FrizerskiSalonObjekti
{
    public class Zakazivanje
    {
        public Zakazivanje() { }

        public DateOnly Datum { get; set; }
        public TimeOnly Vreme_OD { get; set; }
        public bool Moze { get; set; }

    }
}
