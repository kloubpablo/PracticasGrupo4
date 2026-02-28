using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ClientesController : Controller
    {
        private readonly ClientesBussiness _clientesBussiness;

        public ClientesController(ClientesBussiness clienteBussiness)
        {
            _clientesBussiness = clienteBussiness;
        }


        public IActionResult Index()
        {
            return View(_clientesBussiness.GetAllClientes());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Clientes cliente)
        {
            if (!ModelState.IsValid)
            {
                return View(cliente);
            }
            _clientesBussiness.AddClientes(cliente);

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int id)
        {
            return View(_clientesBussiness.GetClientesById(id));
        }


        public IActionResult Details(int id)
        {
            return View(_clientesBussiness.GetClientesById(id));
        }


        [HttpPost]
        public IActionResult Edit(Clientes cliente)
        {
            _clientesBussiness.UpdateClientes(cliente);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            return View(_clientesBussiness.GetClientesById(id));
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmar(int id)
        {
            _clientesBussiness.DeleteClientes(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
