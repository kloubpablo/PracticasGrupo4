using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WebApplicationAPP.Models;

namespace WebApplicationAPP.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new CalculadoraViewModel());
        }

        [HttpPost]
        public IActionResult Index(CalculadoraViewModel modelo)
        {
            
            if (modelo.operacion == "suma")
            {
                modelo.resultado = modelo.valor1 + modelo.valor2;
            }
           
            return View(modelo);
        }
    }
}
