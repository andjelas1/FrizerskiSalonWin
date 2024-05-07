using FrizerskiSalonObjekti.FSObjekti;

namespace FrizerskiSalonObjekti
{
    public class NoviRaspored
    {
        public Radnik Radnik { get; set; }
        public int Mesec { get; set; }
        public int Godina { get; set; }
        public bool Prepodne { get; set; }
        public NoviRaspored()
        {
            Radnik = new Radnik();
            Mesec = 0;
            Godina = 0;
            Prepodne = false;
        }
    }
}
