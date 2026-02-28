using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IServiciosRepository
    {
        List<Servicios> GetAllServicios();
        Servicios GetServiciosById(int id);
        void AddServicios(Servicios servicio);
        void UpdateServicios(Servicios servicio);
        void InactivarteServicios(int id);

    }
}
