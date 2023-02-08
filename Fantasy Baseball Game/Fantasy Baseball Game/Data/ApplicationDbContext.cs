using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Fantasy_Baseball_Game.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        //public DbSet<Player> Players { get; set; }

    }
}
