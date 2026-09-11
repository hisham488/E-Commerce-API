using E_Commerce.Application.Commen;
using E_Commerce.Application.DTOs.Products;

namespace E_Commerce.Application.Contracts
{
    public interface IProductService
    {
        Task<Result<IReadOnlyList<ProductDto>>> GetAllProductsAsync(ProductQueryParams queryParams,CancellationToken ct = default);
        Task<Result<IReadOnlyList<BrandDto>>> GetAllBrandAsync(CancellationToken ct = default);
        Task<Result<IReadOnlyList<TypeDto>>> GetAllTypesAsync(CancellationToken ct = default);
        Task<Result<ProductDto>> GetproductByIdAsync(int id, CancellationToken ct = default);
    }
}
