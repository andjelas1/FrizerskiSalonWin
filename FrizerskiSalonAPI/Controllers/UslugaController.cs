using FrizerskiSalonAPI.FSPristupBazi;
using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.AspNetCore.Mvc;

namespace FrizerskiSalonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UslugaController : ControllerBase
    {
        private readonly fzDbContext _context;
        public UslugaController(fzDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("sveusluge")]
        public IEnumerable<Usluga> Usluge() {
            var pristupBazi = new PristupBazi(_context);
            return pristupBazi.UcitajSveUsluge();
        }

        [HttpPost]
        public void DodajUslugu(Usluga usluga) 
        {
            var pristupBazi = new PristupBazi(_context);
            pristupBazi.KreirajUslugu(usluga);
        }

        [HttpPost]
        [Route("tretmani")]
        public IEnumerable<Radnik> UcitajRadnikeZaUslugu(Usluga usluga)
        {
            var pristupBazi = new PristupBazi(_context);
            return pristupBazi.UcitajRadnikeZaUslugu(usluga);
        }

        [HttpPost]
        [Route("snimiUlsugaRadnik")]
        public void SnimiUlsugaRadnik(List<Tretman> tretmani)
        {
            var pristupBazi = new PristupBazi(_context);
            pristupBazi.SacuvajTretmane(tretmani);
        }
    }
}
