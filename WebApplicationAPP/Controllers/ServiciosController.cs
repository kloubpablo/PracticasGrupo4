using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Bussines;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class ServiciosController : Controller
    {
        private readonly ServiciosBussiness _servicioBussiness;
        
        public ServiciosController(ServiciosBussiness serviciosBussiness)
        {
            _servicioBussiness = serviciosBussiness;
        }


        public IActionResult Index()
        {
            return View(_servicioBussiness.GetAllServicios());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Servicios servicio)
        {
            if(!ModelState.IsValid)
            {
                return View(servicio);
            }
            _servicioBussiness.AddServicios(servicio);

            return RedirectToAction(nameof(Index));
        }



        public IActionResult Edit(int id)
        {
            return View(_servicioBussiness.GetServiciosById(id));
        }


        public IActionResult Details(int id)
        {
            return View(_servicioBussiness.GetServiciosById(id));
        }


        [HttpPost]
        public IActionResult Edit(Servicios servicio)
        {
            _servicioBussiness.UpdateServicios(servicio);
            return RedirectToAction("Index");
        }


        public IActionResult Inactivar(int id)
        {
            return View(_servicioBussiness.GetServiciosById(id));
        }


        [HttpPost, ActionName("Inactivar")]
        public IActionResult InactivarConfirmar(int id)
        {
            _servicioBussiness.InactivarteServicios(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
