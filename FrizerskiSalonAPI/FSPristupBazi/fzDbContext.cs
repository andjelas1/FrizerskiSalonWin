using FrizerskiSalonObjekti.FSObjekti;
using Microsoft.EntityFrameworkCore;

namespace FrizerskiSalonAPI.FSPristupBazi
{
    public class fzDbContext : DbContext
    {
        public fzDbContext(DbContextOptions<fzDbContext> options) : base(options)
        {
            
        }
    }
}
