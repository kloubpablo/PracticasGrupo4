using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Bussines
{
    public class ServiciosBussiness
    {
        private readonly IServiciosRepository _servicioRepository;

        public ServiciosBussiness(IServiciosRepository servicioRepository)
        {
            _servicioRepository = servicioRepository;
        }

        public List<Servicios> GetAllServicios()
        {
            return _servicioRepository.GetAllServicios();
        }

        public Servicios GetServiciosById(int id)
        {
            return _servicioRepository.GetServiciosById(id);
        }

        public void AddServicios(Servicios servicio)
        {
            _servicioRepository.AddServicios(servicio);
        }

        public void UpdateServicios(Servicios servicio)
        {
            _servicioRepository.UpdateServicios(servicio);
        }

        public void InactivarteServicios(int id) {
            _servicioRepository.InactivarteServicios(id);
        }   


    }
}
