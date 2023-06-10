using System.ComponentModel.DataAnnotations;

namespace WebAPI.Models
{
    public class Usuario
    {
        [Key]
        public int? ID { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}