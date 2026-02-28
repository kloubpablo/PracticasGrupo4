using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IInventarioRepository
    {
        List<Inventario> GetAllInventario();
        Inventario GetAllInventarioById(int id);
        void AddInventario(Inventario inventario);
        void UpdateInventario(Inventario inventario);
        void DeleteInventario(int id);

    }
}
