using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using veterinaria.App.Dominio;

namespace veterinaria.App.Persistencia
{

    public class sAppContext : DbContext


    {
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Recomendacion> Recomendaciones { get; set; }
        public DbSet<Visita> Visitas { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Historial> Historias { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {


            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source =(kicakdb)\\MSSQLLocalDB; Initial Catalog = VeterinariaData");
            }

        }


    }


}