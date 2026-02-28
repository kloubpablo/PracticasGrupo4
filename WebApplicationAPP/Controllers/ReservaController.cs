using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplicationAPP.Bussines;
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

    public IActionResult Create()
    {
        ViewBag.Usuarios = new SelectList(_bussines.ListarUsuarios(), "Id", "Nombre");
        ViewBag.Laboratorios = new SelectList(_bussines.ListarLaboratorios(), "Id", "Nombre");
        return View(new Reserva());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Reserva reserva)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Usuarios = new SelectList(_bussines.ListarUsuarios(), "Id", "Nombre");
            ViewBag.Laboratorios = new SelectList(_bussines.ListarLaboratorios(), "Id", "Nombre");
            return View(reserva);
        }

        _bussines.AddReserva(reserva);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        var reserva = _bussines.Buscar(id);
        if (reserva == null) return NotFound();

        ViewBag.Usuarios = new SelectList(_bussines.ListarUsuarios(), "Id", "Nombre");
        ViewBag.Laboratorios = new SelectList(_bussines.ListarLaboratorios(), "Id", "Nombre");
        return View(reserva);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(Reserva reserva)
    {
        if (!ModelState.IsValid)
        {
            ViewBag.Usuarios = new SelectList(_bussines.ListarUsuarios(), "Id", "Nombre");
            ViewBag.Laboratorios = new SelectList(_bussines.ListarLaboratorios(), "Id", "Nombre");
            return View(reserva);
        }

        _bussines.EditReserva(reserva);
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Detalle(int id)
    {
        var reserva = _bussines.Buscar(id);
        if (reserva == null) return NotFound();
        return View(reserva);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult DeleteConfirmar(int id)
    {
        _bussines.DeleteReserva(id);
        return RedirectToAction(nameof(Index));
    }
}
