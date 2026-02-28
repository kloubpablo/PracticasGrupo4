using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Inventario> Inventario { get; set; }
        public DbSet<Servicios> Servicios { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        //public DbSet<WebApplicationAPP.Models.Producto> Productos { get; set; }
    }
}
