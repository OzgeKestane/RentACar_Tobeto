using Business.Request.Brand;
using Business.Responses.Brand;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public AddFuelResponse Add(AddFuelRequest request);
        public IList<Fuel> GetList();
    }
}
