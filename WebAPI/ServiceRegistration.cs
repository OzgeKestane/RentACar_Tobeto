using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI
{ //BU CLASSI SİLEBİLİRİZ, PROGRAMCSDE AYNI İŞLEMLERİ KISAYOLDAN YAPTIK
    public static class ServiceRegistration
    {//readonly dışarıdan atama yapılmasın diye

        public static readonly IBrandDal BrandDal = new InMemoryBrandDal();
        public static readonly BrandBusinessRules BrandBusinessRules = new BrandBusinessRules(BrandDal);
        public static IMapper Mapper => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddBrandRequest, Brand>();
            cfg.CreateMap<Brand, AddBrandResponse>();
        }).CreateMapper();
        public static readonly IBrandService BrandService = new BrandManager(BrandDal, BrandBusinessRules, Mapper);
        //IoC yapımızı kurduğumuzda dependency injection ile daha verimli hale gelecek.

    }
}
