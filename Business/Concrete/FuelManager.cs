﻿using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class FuelManager : IFuelService
    {
        private readonly IFuelDal _fuelDal;
        private readonly FuelBusinessRules _fuelBusinessRules;
        private IMapper _mapper;
        public FuelManager(IFuelDal fuelDal, FuelBusinessRules fuelBusinessRules, IMapper mapper)
        {
            _fuelDal = fuelDal;
            _fuelBusinessRules = fuelBusinessRules;
            _mapper = mapper;
        }

        public AddFuelResponse Add(AddFuelRequest request)
        {
            _fuelBusinessRules.CheckIfFuelNameExists(request.Name);

            Fuel fuelToAdd = _mapper.Map<Fuel>(request);

            _fuelDal.Add(fuelToAdd);

            AddFuelResponse response = _mapper.Map<AddFuelResponse>(fuelToAdd);
            return response;
        }
        public IList<Fuel> GetList()
        {
            IList<Fuel> fuelList = _fuelDal.GetList();
            return fuelList;
        }

    }
}