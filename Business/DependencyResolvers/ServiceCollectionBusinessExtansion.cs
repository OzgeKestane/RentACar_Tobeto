﻿using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Concrete.InMemory;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        public static IServiceCollection AddBusinessServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped
            services
                .AddSingleton<IBrandService, BrandManager>()
                .AddSingleton<IBrandDal, InMemoryBrandDal>()
                .AddSingleton<BrandBusinessRules>();
            services.AddSingleton<IFuelService, FuelManager>().AddSingleton<IFuelDal, InMemoryFuelDal>().AddSingleton<FuelBusinessRules>();
            services
                .AddSingleton<ITransmissionService, TransmissionManager>()
                .AddSingleton<ITransmissionDal, InMemoryTransmissionDal>()
                .AddSingleton<TransmissionBusinessRules>();

            services.AddScoped<IModelService, ModelManager>();
            services.AddScoped<IModelDal, EfModelDal>();
            services.AddScoped<ModelBusinessRules>();

            services.AddSingleton<ICarService, CarManager>();
            services.AddSingleton<ICarDal, InMemoryCarDal>();
            services.AddSingleton<CarBusinessRules>();

            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IUserDal, EfUserDal>();
            //services.AddScoped<UserBusinessRules>();

            services.AddScoped<ICustomerService, CustomerManager>();
            services.AddScoped<ICustomerDal, EfCustomerDal>();
            services.AddScoped<CustomerBusinessRules>();

            services.AddScoped<IIndividualCustomerService, IndividualCustomerManager>();
            services.AddScoped<IIndividualCustomerDal, EfIndividualCustomerDal>();
            services.AddScoped<IndividualCustomerBusinessRules>();

            services.AddScoped<ICorporateCustomerService, CorporateCustomerManager>();
            services.AddScoped<ICorporateCustomerDal, EfCorporateCustomerDal>();
            services.AddScoped<CorporateCustomerBusinessRules>();




            services.AddAutoMapper(Assembly.GetExecutingAssembly()); //fluent yapısı yazım şekli
            services.AddDbContext<RentACarContext>(options => options.UseSqlServer(configuration.GetConnectionString("RentACarMSSQL22")));

            return services;

        }

    }
}
