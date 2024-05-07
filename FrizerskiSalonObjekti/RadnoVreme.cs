namespace FrizerskiSalonObjekti.FSObjekti
{
    public class RadnoVreme
    {
        public RadnoVreme()
        {
            ID_RadnoVreme = 0;
            Datum = DateOnly.MinValue;
            Vreme_Od = TimeOnly.MinValue;
            Vreme_Do = TimeOnly.MinValue;
        }
        public int ID_RadnoVreme {  get; set; }
        public DateOnly Datum {  get; set; }
        public TimeOnly Vreme_Od { get; set; }
        public TimeOnly Vreme_Do { get; set; }
    }
}
