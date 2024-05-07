using FrizerskiSalonAPI.FSPristupBazi;
using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.AspNetCore.Mvc;

namespace FrizerskiSalonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RadnikController : ControllerBase
    {
        private readonly fzDbContext _context;
        public RadnikController(fzDbContext context) { 
            _context = context;
        }
        
        [HttpGet]
        public Radnik Radnik()
        {
            var pristupBazi = new PristupBazi(_context);
            return pristupBazi.UcitajRadnika(5);
        }

        [HttpPost]
        public void DodajRadnik(Radnik radnik)
        {
            var pristupBazi = new PristupBazi(_context);
            pristupBazi.KreirajRadnika(radnik);
        }

        [HttpGet]
        [Route("sviradnici")]
        public IEnumerable<Radnik> Radnici()
        {
            var pristupBazi = new PristupBazi(_context);
            return pristupBazi.UcitajRadnike();
        }

        [HttpPost]
        [Route("radnovreme")]
        public IEnumerable<RadnoVreme> RadnoVreme(Radnik radnik)
        {
            var pristupBazi = new PristupBazi(_context);
            return pristupBazi.UcitajRadnoVremeRadnika(radnik);
        }

        [HttpPost]
        [Route("noviraspored")]
        public void KreirajRaspored(NoviRaspored noviRaspored)
        {
            var pristupBazi = new PristupBazi(_context);
            pristupBazi.KreirajRasporedZaRadnika(noviRaspored.Radnik, noviRaspored.Mesec, noviRaspored.Godina, noviRaspored.Prepodne);
        }
    }
}
