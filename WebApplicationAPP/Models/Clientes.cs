using Microsoft.AspNetCore.Http.HttpResults;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("Cliente_GeraldRB")]
    public class Clientes
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public String Correo { get; set; }
        public String Telefono{ get; set; }
        public String Direccion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
