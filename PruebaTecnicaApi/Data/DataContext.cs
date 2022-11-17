using Microsoft.EntityFrameworkCore;

namespace PruebaTecnicaApi.Data
{
    public class DataContext : DbContext    
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Status> Status { get; set; }

        public DbSet<Zone> Zone { get; set; }

        public DbSet<Hause> Hause { get; set; }



    }
}
