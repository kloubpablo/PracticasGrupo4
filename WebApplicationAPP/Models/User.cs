using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("User_G4")]
    public class User
    {
        [Key]
        [Column("Id_Usuario")]
        public int IdUsuario { get; set; }
        public string Nombre { get; set; }

        public string Tipo { get; set; }

        public string Correo { get; set; }


    }
}
