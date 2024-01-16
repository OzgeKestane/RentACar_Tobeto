﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Concrete;
using Business.Request.Fuel;
using Business.Responses.Fuel;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace WebAPI
{
    public class FuelServiceRegistration
    {
        public static readonly IFuelDal FuelDal = new InMemoryFuelDal();
        public static readonly FuelBusinessRules FuelBusinessRules = new FuelBusinessRules(FuelDal);
        public static IMapper Mapper => new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<AddFuelRequest, Fuel>();
            cfg.CreateMap<Fuel, AddFuelResponse>();
        }).CreateMapper();
        public static readonly IFuelService FuelService = new FuelManager(FuelDal, FuelBusinessRules, Mapper);

    }
}
