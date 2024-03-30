using Microsoft.AspNetCore.Mvc;
using Sales.AppServices.Contracts;

namespace Sales.API.Controllers
{
    public class VentaController : Controller
    {
        private readonly IVentaService ventaServ;

        public VentaController(IVentaService ventaServ)
        {
            this.ventaServ = ventaServ;
        }

        [HttpGet("GetTotalVentasByUser{idUsuario}")]
        public async Task<IActionResult> GetTotalVentasByUser(int idUsuario)
        {
            var result = await this.ventaServ.GetTotalDeVentas(idUsuario);
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }
    }
}
