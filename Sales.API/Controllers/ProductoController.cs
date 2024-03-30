using Microsoft.AspNetCore.Mvc;
using Sales.AppServices.Contracts;

namespace Sales.API.Controllers
{
    public class ProductoController : Controller
    {
        private readonly IProductoService productoService;

        public ProductoController(IProductoService productoService)
        {
            this.productoService = productoService;
        }

        [HttpGet("GetProductoByCategory{idCategoria}")]
        public async Task<IActionResult> GetProductoByCategory(int idCategoria)
        {
            var result = await this.productoService.GetProductByCategory(idCategoria);
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }
    }
}
