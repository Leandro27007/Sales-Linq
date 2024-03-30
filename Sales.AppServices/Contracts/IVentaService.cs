using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using Sales.Infraestructure.Models;

namespace Sales.AppServices.Contracts
{
    public interface IVentaService
    {
        public Task<ServiceResult> GetVenta(string numeroVenta);
        public Task<ServiceResult> GetVentas();
        public Task<ServiceResult> HacerVenta(HacerVentaDTO venta);
      public Task<ServiceResult> GetTotalDeVentas(int idUsuario);

    }
}
