using E_Commerce.Domain.Commen;

namespace E_Commerce.Domain.Entities.Products
{
    public class ProductPrand:BaseEntities<int>
    {
        public string Name { get; set; } = default!;
    }
}
