using WebApplicationAPP.Models;

public interface IReservaRepository
{
    List<Reserva> Listar();
    Reserva BuscarPorId(int id);
    void AddReserva(Reserva reserva);
    List<Servicios> ListarServiciosActivos();
    Servicios ObtenerServicio(int idServicio);
}
