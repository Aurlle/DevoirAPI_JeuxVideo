using Microsoft.EntityFrameworkCore;

namespace DevoirAPI.EF
{
    public class JeuxContext : DbContext
    {
        public class JeuxVideoContext : DbContext
        {
            public DbSet<Jeu> Jeux { get; set; }
            public DbSet<Genre> Genres { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(""); //Mettre la connection string ici
            }
        }

    }
}