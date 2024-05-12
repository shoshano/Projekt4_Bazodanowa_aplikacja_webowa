using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt4_Bazodanowa_aplikacja_webowa;

namespace Projekt4_Bazodanowa_aplikacja_webowa.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Projekt4_Bazodanowa_aplikacja_webowa.Movie> Movie { get; set; } = default!;
    }
}
