using Microsoft.AspNetCore.Mvc;
using WebApplicationAPP.Models;

public class ReservaController : Controller
{
    private readonly ReservaBussines _bussines;

    public ReservaController(ReservaBussines bussines)
    {
        _bussines = bussines;
    }

    public IActionResult Index()
    {
        return View(_bussines.Listar());
    }

    [HttpGet]
    public IActionResult Create()
    {
        ViewBag.Servicios = _bussines.ListarServiciosActivos();
        return View(new Reserva());
    }

    [HttpPost]
    public IActionResult Create(Reserva reserva)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Servicios = _bussines.ListarServiciosActivos();
            return View(reserva);
        }

        _bussines.AddReserva(reserva);
        return RedirectToAction("Index");
    }

    public IActionResult Buscar()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Buscar(int id)
    {
        var reserva = _bussines.Buscar(id);
        if (reserva == null)
        {
            ViewBag.Mensaje =
                "Estimado asociado, no se ha encontrado la reserva, favor realizar una nueva.";
            return View();
        }

        return View("Detalle", reserva);
    }

    public IActionResult Detalle(int id)
    {
        return View(_bussines.Buscar(id));
    }
}
