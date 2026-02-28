using WebApplicationAPP.Models;
using System.Collections.Generic;

public class ReservaBussines
{
    private readonly IReservaRepository _repo;

    public ReservaBussines(IReservaRepository repo)
    {
        _repo = repo;
    }

    public List<Reserva> Listar() => _repo.Listar();
    public Reserva Buscar(int id) => _repo.BuscarPorId(id);
    public void AddReserva(Reserva reserva) => _repo.AddReserva(reserva);
    public void EditReserva(Reserva reserva) => _repo.EditReserva(reserva);
    public void DeleteReserva(int id) => _repo.Eliminar(id);

    public List<User> ListarUsuarios() => _repo.ListarUsuarios();
    public List<Laboratory> ListarLaboratorios() => _repo.ListarLaboratorios();
}