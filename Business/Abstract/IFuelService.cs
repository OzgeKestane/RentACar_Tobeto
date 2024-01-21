using Business.Request.Fuel;
using Business.Responses.Fuel;

namespace Business.Abstract
{
    public interface IFuelService
    {
        public AddFuelResponse Add(AddFuelRequest request);
        public GetFuelListResponse GetList(GetFuelListRequest request);
        public UpdateFuelResponse Update(int id, UpdateFuelRequest request);
        public DeleteFuelResponse Delete(int id);
    }
}
