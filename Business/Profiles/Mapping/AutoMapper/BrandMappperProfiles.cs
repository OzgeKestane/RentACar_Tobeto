using AutoMapper;
using Business.Dtos.Brand;
using Business.Request.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Profiles.Mapping.AutoMapper
{
    public class BrandMappperProfiles : Profile
    {
        public BrandMappperProfiles()
        {
            CreateMap<AddBrandRequest, Brand>();
            CreateMap<Brand, AddBrandResponse>();
            //addBrand();
            CreateMap<Brand, BrandListItemDto>();
            CreateMap<IList<Brand>, GetBrandListResponse>().ForMember(destinationMember: dest => dest.Items,
                memberOptions: opt => opt.MapFrom(mapExpression: src => src));
        }
        //private void addBrand()
        //{
        //    CreateMap<AddBrandRequest, Brand>();
        //    CreateMap<Brand, AddBrandResponse>();
        //}
    }
}
