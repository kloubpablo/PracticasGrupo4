using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class InventarioController : Controller
    {
        private readonly InventarioBussiness _inventarioBussiness;

        public InventarioController(InventarioBussiness inventarioBussiness)
        {
            _inventarioBussiness = inventarioBussiness;
        }


        public IActionResult Index()
        {
            return View(_inventarioBussiness.GetAllInventario());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Inventario inventario)
        {
            if (!ModelState.IsValid)
            {
                return View(inventario);
            }
            _inventarioBussiness.AddInventario(inventario);

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int id)
        {
            return View(_inventarioBussiness.GetInventarioById(id));
        }


        public IActionResult Details(int id)
        {
            return View(_inventarioBussiness.GetInventarioById(id));
        }


        [HttpPost]
        public IActionResult Edit(Inventario inventario)
        {
            _inventarioBussiness.UpdateInventario(inventario);
            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {
            return View(_inventarioBussiness.GetInventarioById(id));
        }


        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmar(int id)
        {
            _inventarioBussiness.DeleteInventario(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
