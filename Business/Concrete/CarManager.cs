using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Car;
using Business.Responses.Car;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;
        private readonly CarBusinessRules _carBusinessRules;
        private IMapper _mapper;

        public CarManager(ICarDal carDal, CarBusinessRules carBusinessRules, IMapper mapper)
        {
            _carDal = carDal;
            _carBusinessRules = carBusinessRules;
            _mapper = mapper;
        }

        public AddCarResponse Add(AddCarRequest request)
        {
            _carBusinessRules.CheckIfCarModelYearsValid(request.ModelYear);
            int currentYear = DateTime.Now.Year;
            if (request.ModelYear < currentYear - 20)
            {
                throw new BusinessException("Car model year must be within the last 20 years and not exceed the current year.");
            }

            Car carToAdd = _mapper.Map<Car>(request);
            _carDal.Add(carToAdd);
            AddCarResponse response = _mapper.Map<AddCarResponse>(carToAdd);
            return response;
        }

        public GetCarListResponse GetList(GetCarListRequest request)
        {
            IList<Car> carList = _carDal.GetList();
            GetCarListResponse response = _mapper.Map<GetCarListResponse>(carList);
            return response;
        }

        public UpdateCarResponse Update(UpdateCarRequest request, int id)
        {
            _carBusinessRules.CheckIfCarModelYearsValid(request.ModelYear);
            int currentYear = DateTime.Now.Year;
            if (request.ModelYear < currentYear - 20)
            {
                throw new BusinessException("Car model year must be within the last 20 years and not exceed the current year.");
            }
            Car carToUpdate = _carBusinessRules.FindBrandId(id);
            carToUpdate.CarState = request.CarState;
            carToUpdate.UpdatedAt = DateTime.Now;
            carToUpdate.ColorId = request.ColorId;
            carToUpdate.Plate = request.Plate;
            carToUpdate.Kilometer = request.Kilometer;
            carToUpdate.ModelId = request.ModelId;
            carToUpdate.ModelYear = request.ModelYear;

            UpdateCarResponse response = _mapper.Map<UpdateCarResponse>(carToUpdate);
            return response;

        }

        public DeleteCarResponse Delete(int id)
        {
            Car carToDelete = _carBusinessRules.FindBrandId(id);
            carToDelete.DeletedAt = DateTime.Now;
            DeleteCarResponse response = _mapper.Map<DeleteCarResponse>(carToDelete);
            return response;
        }
    }
}
