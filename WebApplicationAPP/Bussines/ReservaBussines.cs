using WebApplicationAPP.Models;

public class ReservaBussines
{
    private readonly IReservaRepository _repo;

    public ReservaBussines(IReservaRepository repo)
    {
        _repo = repo;
    }

    public List<Reserva> Listar()
        => _repo.Listar();

    public Reserva Buscar(int id)
        => _repo.BuscarPorId(id);

    public List<Servicios> ListarServiciosActivos()
        => _repo.ListarServiciosActivos();

    public void AddReserva(Reserva reserva)
    {
        var servicio = _repo.ObtenerServicio(reserva.IdServicio);

        ///////Calculo automático del monto total//////////
        reserva.MontoTotal = (servicio.Monto * servicio.IVA) + servicio.Monto;

        reserva.FechaDeRegistro = DateTime.Now;

        _repo.AddReserva(reserva); 
    }
}
