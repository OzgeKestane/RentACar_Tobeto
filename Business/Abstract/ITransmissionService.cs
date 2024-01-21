using Business.Request.Transmission;
using Business.Responses.Transmission;

namespace Business.Abstract
{
    public interface ITransmissionService
    {
        public AddTransmissionResponse Add(AddTransmissionRequest request);
        public UpdateTransmissionResponse Update(int id, UpdateTransmissionRequest request);
        public DeleteTransmissionResponse Delete(int id);
        public GetTransmissionListResponse GetList(GetTransmissionListRequest request);

    }
}
