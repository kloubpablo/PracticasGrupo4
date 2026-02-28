using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("RESERVAS_G4")]
    public class Reserva
    {
        public int Id { get; set; }

        [Required]
        public string NombreDelAsociado { get; set; }

        [Required]
        public string Identificacion { get; set; }

        [Required]
        public string Telefono { get; set; }

        [Required]
        public string Correo { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [Required]
        public string Direccion { get; set; }

        public decimal MontoTotal { get; set; }

        public DateTime FechaDelServicio { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public int IdServicio { get; set; }

        [ForeignKey(nameof(IdServicio))]
        public Servicios Servicio { get; set; }
    }
}

