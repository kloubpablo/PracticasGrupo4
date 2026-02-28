using Microsoft.EntityFrameworkCore;
using WebApplicationAPP.Data;
using WebApplicationAPP.Models;
using System.Collections.Generic;
using System.Linq;

public class ReservaRepository : IReservaRepository
{
    private readonly AppDbContext _context;

    public ReservaRepository(AppDbContext context)
    {
        _context = context;
    }

    public List<Reserva> Listar()
        => _context.Reservas.Include(r => r.User)
                            .Include(r => r.Laboratory)
                            .ToList();

    public Reserva BuscarPorId(int id)
        => _context.Reservas.Include(r => r.User)
                            .Include(r => r.Laboratory)
                            .FirstOrDefault(r => r.IdReserva == id);

    public void AddReserva(Reserva reserva)
    {
        _context.Reservas.Add(reserva);
        _context.SaveChanges();
    }

    public void EditReserva(Reserva reserva)
    {
        var r = _context.Reservas.Find(reserva.IdReserva);
        if (r != null)
        {
            r.IdUsuario = reserva.IdUsuario;
            r.IdLaboratorio = reserva.IdLaboratorio;
            r.FechaHora = reserva.FechaHora;
            _context.SaveChanges();
        }
    }

    public List<User> ListarUsuarios()
        => _context.Users.ToList();

    public List<Laboratory> ListarLaboratorios()
        => _context.Laboratories.ToList();

    public void Eliminar(int id)
    {
        var reserva = _context.Reservas.Find(id);
        if (reserva != null)
        {
            _context.Reservas.Remove(reserva);
            _context.SaveChanges();
        }
    }
}