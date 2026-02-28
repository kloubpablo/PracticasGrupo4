using WebApplicationAPP.Models;
using System.Collections.Generic;

public interface IReservaRepository
{
    List<Reserva> Listar();
    Reserva BuscarPorId(int id);
    void AddReserva(Reserva reserva);
    void EditReserva(Reserva reserva); // Nuevo método para editar

    List<User> ListarUsuarios();
    List<Laboratory> ListarLaboratorios();

    void Eliminar(int id);
}
