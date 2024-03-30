using Sales.AppServices.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sales.AppServices.Contracts
{
    public interface IProductoService
    {

        Task<ServiceResult> GetProductByCategory(int categoriId);
    }
}
