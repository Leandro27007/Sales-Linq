﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;

namespace Sales.Infraestructure.Interfaces
{
    public interface IProductoDb : IDaoBase<Producto>
    {
        Task<List<Producto>> GetProductByCategory(int idCategoria);
    }
}
