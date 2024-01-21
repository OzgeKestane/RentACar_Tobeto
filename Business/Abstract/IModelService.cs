using Business.Request.Model;
using Business.Responses.Model;

namespace Business.Abstract
{
    public interface IModelService
    {
        public AddModelResponse Add(AddModelRequest request);
        public UpdateModelResponse Update(int id, UpdateModelRequest request);
        public DeleteModelResponse Delete(int id);
        public GetModelListResponse GetList(GetModelListRequest request);
    }
}
