using Microsoft.EntityFrameworkCore;
using projeto1;


namespace projeto1
{
    public class DbGames : DbContext
    {

        public DbGames(DbContextOptions<DbGames> options) : base (options)
        {
            

        }
        public DbSet<Jogos> Jogos{get; set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Jogos>()
             .Property(j => j.Status)
             .HasConversion<string>();
        }

    }
}