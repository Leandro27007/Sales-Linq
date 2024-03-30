using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.AppServices.Services
{
    public class ProductoService : IProductoService
    {
        private readonly IProductoDb db;

        public ProductoService(IProductoDb db)
        {
            this.db = db;
        }
        public async Task<ServiceResult> GetProductByCategory(int categoriId)
        {
            ServiceResult result = new();

            var productos = await db.GetProductByCategory(categoriId);

            result.Data = productos;

            return result;
        }
    }
}
