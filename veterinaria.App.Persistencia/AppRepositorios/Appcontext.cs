using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using veterinaria.App.Dominio;

namespace veterinaria.App.Persistence.AppRepositorios
{
    
    public class AppContext : DbContext


    {
        public DbSet<Recomendacion> recomendaciones { get; set; }
        public DbSet<Visita> visitas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(! optionsBuilder.IsConfigured)
            {
                    optionsBuilder
                    .UseSqlServer("Data Source =(kicakdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaData");
            }
          
        }


    }
}