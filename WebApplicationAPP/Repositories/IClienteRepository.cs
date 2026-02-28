using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IClienteRepository
    {
        List<Clientes> GetAllClientes();
        Clientes GetClientesById(int id);
        void AddClientes(Clientes cliente);
        void UpdateClientes(Clientes cliente);
        void DeleteClientes(int id);

    }
}
