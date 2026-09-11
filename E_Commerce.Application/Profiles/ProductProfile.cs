using AutoMapper;
using E_Commerce.Application.DTOs.Products;
using E_Commerce.Domain.Entities.Products;

namespace E_Commerce.Application.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<ProductBrand, BrandDto>();
            CreateMap<ProductType, TypeDto>();
            CreateMap<Product, ProductDto>()
            .ForMember(dest => dest.productBrand, opt => opt.MapFrom(src => src.productBrand.Name))
            .ForMember(dest => dest.productType, opt => opt.MapFrom(src => src.ProductType.Name))
            .ForMember(dest => dest.PictureUrl, opt => opt.MapFrom<PictureUrlResolver>());
        }

    }
}
