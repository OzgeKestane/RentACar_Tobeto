using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business.DependencyResolvers
{
    public static class ServiceCollectionBusinessExtansion
    {
        //Extension
        //metodun ve barındığı classın static olması gerekiyor.
        //ilk parametre genişleteceğimiz tip olmalı ve başında this keywordü olmalı
        //IServiceColleciton'u genişletmek istiyoruz
        // microsoft.extension.dependencyinjeciton abstractions yükledik.
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services
                .AddSingleton<IBrandService, BrandManager>()
                .AddSingleton<IBrandDal, InMemoryBrandDal>()
                .AddSingleton<BrandBusinessRules>();
            services.AddSingleton<IFuelService, FuelManager>().AddSingleton<IFuelDal, InMemoryFuelDal>().AddSingleton<FuelBusinessRules>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly()); //fluent yapısı yazım şekli
            return services;

        }

    }
}
