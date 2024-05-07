namespace FrizerskiSalonObjekti.FSObjekti
{
    public class Tretman
    {
        public Tretman()
        {
            ID_Tretman = 0;
            Usluga = new Usluga();
            Radnik = new Radnik();
        }

        public Tretman(int id, Usluga usluga, Radnik radnik)
        {
            ID_Tretman = id;
            Usluga = usluga;
            Radnik = radnik;
        }
        public int ID_Tretman {  get; set; }
        public Usluga Usluga { get; set; }
        public Radnik Radnik { get; set; }
    }
}
