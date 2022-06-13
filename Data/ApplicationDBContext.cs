using Microsoft.EntityFrameworkCore;
using Avatar.Models;

namespace Avatar.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        
        public DbSet<Fighters> Fighters { get; set; }
        
    }
}
