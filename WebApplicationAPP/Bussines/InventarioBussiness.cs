using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class InventarioBussiness
    {
        private readonly IInventarioRepository _inventarioRepository;

        public InventarioBussiness(IInventarioRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public List<Inventario> GetAllInventario()
        {
            return _inventarioRepository.GetAllInventario();
        }

        public Inventario GetInventarioById(int id)
        {
            return _inventarioRepository.GetAllInventarioById(id);
        }

        public void AddInventario(Inventario inventario)
        {
            _inventarioRepository.AddInventario(inventario);
        }

        public void UpdateInventario(Inventario inventario)
        {
            _inventarioRepository.UpdateInventario(inventario);
        }

        public void DeleteInventario(int id)
        {
            _inventarioRepository.DeleteInventario(id);
        }
    }
}
