using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class ServiciosRepository : IServiciosRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public ServiciosRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Servicios> GetAllServicios() { 
            return _context.Servicios.ToList();
        }
        public Servicios GetServiciosById(int id) { 
            return _context.Servicios.Find(id);
        }

        public void AddServicios(Servicios servicio) { 
            _context.Servicios.Add(servicio);
            _context.SaveChanges();
        }

        public void UpdateServicios(Servicios servicio)
        {
            _context.Servicios.Update(servicio);
            _context.SaveChanges();       
        }

        public void InactivarteServicios(int id) { 
            var servicio = GetServiciosById(id);
            if (servicio != null)
            {
                servicio.Estado = false;
                _context.Servicios.Update(servicio);
                _context.SaveChanges();
            }
        }

    }
}
