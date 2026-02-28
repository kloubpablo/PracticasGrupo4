using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class InventarioRepository : IInventarioRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public InventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Inventario> GetAllInventario() { 
            return _context.Inventario.ToList();
        }
        public Inventario GetAllInventarioById(int id) { 
            return _context.Inventario.Find(id);
        }

        public void AddInventario(Inventario inventarios) { 
            _context.Inventario.Add(inventarios);
            _context.SaveChanges();
        }

        public void UpdateInventario(Inventario inventarios)
        {
            _context.Inventario.Update(inventarios);
            _context.SaveChanges();       
        }

        public void DeleteInventario(int id) { 
            var inventario = GetAllInventarioById(id);
            if (inventario != null)
            {
                _context.Inventario.Remove(inventario);
                _context.SaveChanges();
            }
        }

    }
}
