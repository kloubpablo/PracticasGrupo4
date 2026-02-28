using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("SERVICIOS_G4")]
    public class Servicios
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public decimal Monto { get; set; }

        public decimal IVA { get; set; }

        public int AreaServicio { get; set; }

        public string Encargado { get; set; }

        public string Sucursal { get; set; }

        public DateTime FechaDeRegistro { get; set; }

        public DateTime? FechaDeModificacion { get; set; } 

        public bool Estado { get; set; }  
    }
}
