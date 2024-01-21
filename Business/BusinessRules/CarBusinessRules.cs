using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{


    public class CarBusinessRules
    {
        private readonly ICarDal _carDal;

        public CarBusinessRules(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public Car FindBrandId(int id)
        {
            Car car = _carDal.GetList().SingleOrDefault(x => x.Id == id);
            return car;
        }
        public Car CheckIfCarModelYearsValid(int modelYear)
        {

            Car car = _carDal.GetList().SingleOrDefault(x => x.ModelYear == modelYear);
            return car;
        }

    }
}
