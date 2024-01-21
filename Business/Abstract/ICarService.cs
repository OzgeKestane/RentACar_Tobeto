using Business.Request.Car;
using Business.Responses.Car;

namespace Business.Abstract
{
    public interface ICarService
    {
        public AddCarResponse Add(AddCarRequest request);
        public UpdateCarResponse Update(UpdateCarRequest request, int id);
        public DeleteCarResponse Delete(int id);
        public GetCarListResponse GetList(GetCarListRequest request);
    }
}
