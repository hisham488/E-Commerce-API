
using E_Commerce.Application.Commen;
using E_Commerce.Domain.Contracts;
using E_Commerce.Domain.Entities.Products;

namespace E_Commerce.Application.Specifications
{
    internal class ProductwithTypeAndBrandSpec : BaseSpecification<Product, int>
    {
        public ProductwithTypeAndBrandSpec(ProductQueryParams queryParams) 
            : base(p=>(!queryParams.BrandId.HasValue || p.BrandId == queryParams.BrandId)
            &&(!queryParams.TypeId.HasValue || p.TypeId==queryParams.TypeId.Value)
            &&(string.IsNullOrWhiteSpace(queryParams.SearchValue)||p.Name.ToLower().Contains(queryParams.SearchValue.ToLower())))
        {
            AddInclude(p=> p.ProductType);
            AddInclude(p=> p.productBrand);
        }
        public ProductwithTypeAndBrandSpec(int id):base(x=>x.Id==id)
        {

            AddInclude(p=> p.ProductType);
            AddInclude(p=> p.productBrand);
            
        }
    }
}
