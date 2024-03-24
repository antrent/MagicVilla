using System.ComponentModel.DataAnnotations;

namespace MagicVilla_Web.Models.Dto
{
    public class VillaDto
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Nombre { get; set; }
        public string Detalle { get; set; }

        [Required]
        public double Tarifa { get; set; }
        public int Ocupantes { get; set; }
        public int MetrosCuadrados { get; set; }
        public String ImagenUrl { get; set; }
        public String Amenidad { get; set; }
    }
}
