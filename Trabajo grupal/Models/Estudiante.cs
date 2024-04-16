using System.ComponentModel.DataAnnotations;

namespace Trabajo_grupal.Models
{
    public class Estudiante
    {
        [Key]
        public required  int IdBanner { get; set; }
        public string? Nombre { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public DateTime? FechaVacunacion { get; set; }
        public Vacuna vacuna { get; set; }
        public Recinto_Vacuanción recinto { get; set; }
    }
    

}
