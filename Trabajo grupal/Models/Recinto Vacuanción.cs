using System.ComponentModel.DataAnnotations;

namespace Trabajo_grupal.Models
{
    public class Recinto_Vacuanción
    {
        [Key]
        public required String Direccion { get; set; }
        public required String Ciudad { get; set; }

    }
}
