using FrizerskiSalonAPI.FSPristupBazi;
using FrizerskiSalonObjekti;
using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.AspNetCore.Mvc;

namespace FrizerskiSalonAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ZakazivanjeController : ControllerBase
    {
        private readonly fzDbContext _context;
        public ZakazivanjeController(fzDbContext context)
        {
            _context = context;
        }


        [HttpPost]
        [Route("pronadjitermin")]
        public void PronadjiTermin(ZakazivanjeZahtev zahtev)
        {
            var pristupBazi = new PristupBazi(_context);
            pristupBazi.PronadjiTermin(zahtev);
        }
    }
}
