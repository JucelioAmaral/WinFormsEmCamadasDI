using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Linq;
using WindonsFormsUsingDI.Domain;

namespace WindonsFormsUsingDI.Repository
{
    public class DatabaseContext : DbContext
    {
      
        public string connection = ConfigurationManager.ConnectionStrings["ConnectionDatabaseWinForDI"].ConnectionString;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        public DbSet<Dono> tblDono { get; set; }
        public DbSet<Cao> tblCao { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // SERVERIA PARA CRIAR MIGRATIONS CASO FUNCIONASSE. MAS COMO O .Net framework 4.6.1 não funcionaou com o .Net Standard, criei o BD na mão.
            ////That would turn off cascade delete on all the relationships. Cascade delete may be a desired feature for some use cases.
            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            //{
            //    relationship.DeleteBehavior = DeleteBehavior.Restrict;
            //}
            ////Foi necessário colocar esse Foreach acima para conseguir criar a migration, devido delete cascade.

            //modelBuilder.Entity<Dono>()
            //            .HasMany(d => d.Caes)
            //            .WithOne(c => c.Dono)
            //            .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
