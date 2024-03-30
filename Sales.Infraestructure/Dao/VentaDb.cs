using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;
using Sales.Infraestructure.Models;

namespace Sales.Infraestructure.Dao
{
    public class VentaDb : DaoBase<Venta>, IVentaDb
    {

        private readonly SalesContext context;
        private DbSet<Venta> entities;

        public VentaDb(SalesContext context) : base(context)
        {
            this.context = context;
            this.entities = context.Set<Venta>();
        }

        public async Task<TotalDeVentaPorUsuarioResult> GetTotalDeVentas(int idUsuario)
        {
            try
            {

                //LINQ
                var query = await (from us in context.Usuario
                                   where us.Id == idUsuario
                                   join vt in context.Venta on us.Id equals vt.IdUsuario
                                   group vt by new { us.Id, us.Nombre } into grp
                                   select new TotalDeVentaPorUsuarioResult()
                                   {
                                       Vendedor = grp.Key.Nombre,
                                       CantidadVentas = grp.Count()

                                   }).FirstOrDefaultAsync();

                return query;

            }
            catch (Exception ex)
            {
                return null;
            }


        }
    }
}
