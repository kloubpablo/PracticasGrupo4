using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("Reservation_G4")]
    public class Reserva
    {
        [Key]
        [Column("Id_Reserva")]
        public int IdReserva { get; set; }

        [Required]
        [Column("Id_Usuario")]
        public int IdUsuario { get; set; }

        [Required]
        [Column("Id_Laboratorio")]
        public int IdLaboratorio { get; set; }

        [Required]
        public DateTime FechaHora { get; set; }

        [ForeignKey("IdUsuario")]
        public User User { get; set; }

        [ForeignKey("Id_Laboratorio")]
        public Laboratory Laboratory { get; set; }
    }
}