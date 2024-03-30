using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

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



    }
}
