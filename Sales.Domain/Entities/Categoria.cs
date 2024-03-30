using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Categoria : BaseAuditable, IActivable
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }

    }
}
