using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ClientesBussiness
    {
        private readonly IClienteRepository _clienteRepository;

        public ClientesBussiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public List<Clientes> GetAllClientes()
        {
            return _clienteRepository.GetAllClientes();
        }

        public Clientes GetClientesById(int id)
        {
            return _clienteRepository.GetClientesById(id);
        }

        public void AddClientes(Clientes cliente)
        {
            _clienteRepository.AddClientes(cliente);
        }

        public void UpdateClientes(Clientes cliente)
        {
            _clienteRepository.UpdateClientes(cliente);
        }

        public void DeleteClientes(int id) {
            _clienteRepository.DeleteClientes(id);
        }   


    }
}
