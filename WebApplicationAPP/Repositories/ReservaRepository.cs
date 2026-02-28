using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Data;
using WebApplicationAPP.Models;

public class ReservaRepository : IReservaRepository
{
    private readonly AppDbContext _context;

    public ReservaRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Reserva> Listar()
    {
        return _context.Reservas
            .Include(r => r.Servicio)
            .ToList();
    }

    public Reserva BuscarPorId(int id)
    {
        return _context.Reservas
            .Include(r => r.Servicio)
            .FirstOrDefault(r => r.Id == id);
    }

    public void AddReserva(Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        _context.SaveChanges(); 

    public List<Servicios> ListarServiciosActivos()
    {
        return _context.Servicios
            .Where(s => s.Estado == true)
            .ToList();
    }

    public Servicios ObtenerServicio(int idServicio)
    {
        return _context.Servicios
            .FirstOrDefault(s => s.Id == idServicio);
    }
}
