using FrizerskiSalonObjekti.FSObjekti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FrizerskiSalonObjekti
{
    public  class ZakazivanjeZahtev
    {
        public ZakazivanjeZahtev()
        {
            Usluge = new List<Usluga>();
        }
        public List<Usluga> Usluge {  get; set; }
        public DateOnly Datum { get; set; }
        public bool Prepodne { get; set; } 
    }
}
