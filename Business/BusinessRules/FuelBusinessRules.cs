using DataAccess.Abstract;

namespace Business.BusinessRules
{
    public class FuelBusinessRules
    {
        private readonly IFuelDal _fuelDal;

        public FuelBusinessRules(IFuelDal fuelDal)
        {
            _fuelDal = fuelDal;
        }

        public void CheckIfFuelNameExists(string fuelName)
        {
            bool isExists = _fuelDal.GetList().Any(f => f.Name == fuelName);
            if (isExists)
            {
                throw new Exception("Brand already exists.");
            }

        }

    }




}
