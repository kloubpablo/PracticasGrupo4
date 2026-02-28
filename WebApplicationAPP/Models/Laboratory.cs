using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("Laboratory_G4")]
    public class Laboratory
    {
        [Key]
        [Column("Id_Laboratorio")]
        public int IdLaboratorio { get; set; }

        public string Nombre { get; set; }

        public string Responsable { get; set; }

        public int Capacidad { get; set; }
    }
}
