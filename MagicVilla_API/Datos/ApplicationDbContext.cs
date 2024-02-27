using MagicVilla_API.Modelos;
using Microsoft.EntityFrameworkCore;
using System.Xml.Schema;

namespace MagicVilla_API.Datos
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre="Villa Real",
                    Detalle="Detalle de la Villa Real...",
                    ImagenUrl="",
                    Ocupantes=5,
                    MetrosCuadrados=40,
                    Tarifa=200,
                    Amenidad="",
                    FechaCreacion=DateTime.Now,
                    FechaActualizacion=DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa Maria",
                    Detalle = "Detalle de la Villa Maria...",
                    ImagenUrl = "",
                    Ocupantes = 6,
                    MetrosCuadrados = 50,
                    Tarifa = 300,
                    Amenidad = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );
        }

    }
}
