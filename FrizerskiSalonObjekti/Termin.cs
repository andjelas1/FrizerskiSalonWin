using FrizerskiSalonObjekti.FSObjekti;

namespace FrizerskiSalonObjekti
{
    public class Termin
    {
        public Termin()
        {
        }
        public Usluga Usluga {  get; set; }
        public Radnik Radnik { get; set; }
        public TimeOnly Vreme_Od { get; set; }

    }
}
