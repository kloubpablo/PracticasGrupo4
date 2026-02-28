using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        ///Declarar nuestras funciones por ejemplo
        /////CRUD
        ///
        private readonly AppDbContext _context;
        public ClienteRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Clientes> GetAllClientes() { 
            return _context.Clientes.ToList();
        }
        public Clientes GetClientesById(int id) { 
            return _context.Clientes.Find(id);
        }

        public void AddClientes(Clientes cliente) { 
            _context.Clientes.Add(cliente);
            _context.SaveChanges();
        }

        public void UpdateClientes(Clientes cliente)
        {
            _context.Clientes.Update(cliente);
            _context.SaveChanges();       
        }

        public void DeleteClientes(int id) { 
            var cliente = GetClientesById(id);
            if (cliente != null)
            {
                _context.Clientes.Remove(cliente);
                _context.SaveChanges();
            }
        }

    }
}
