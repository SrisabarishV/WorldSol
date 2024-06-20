using Microsoft.EntityFrameworkCore;
using World.Web.Models;

namespace World.Web.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) 
        {

        }
        public DbSet<Country> Countries { get; set; }
    }
}
