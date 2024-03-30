
using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class ProductoDb : DaoBase<Producto>, IProductoDb
    {
        private readonly List<Producto> _Productos;
        private readonly SalesContext context;
        private DbSet<Producto> entities;
        public ProductoDb(SalesContext context) : base(context)
        {
            this.context = context;
            this.entities = context.Set<Producto>();

        }



        public async Task<List<Producto>> GetProductByCategory(int idCategoria)
        {


            try
            {

                //LINQ
                var query = await (from pdt in context.Producto
                             join cat in context.Categoria on pdt.IdCategoria equals cat.Id
                                   where pdt.Eliminado == false
                             && cat.Eliminado == false
                             
                             select new Producto()
                             {
                                 Id = pdt.Id,
                                 CodigoBarra = pdt.CodigoBarra,
                                 Marca = pdt.Marca,
                                 Stock = pdt.Stock,
                                 NombreCategoria = cat.Descripcion

                             }).ToListAsync();

                return query;
        
            }
            catch (Exception ex)
            {
                return null;
            }

   

        }
    }
}
