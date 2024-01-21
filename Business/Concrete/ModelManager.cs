using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Model;
using Business.Responses.Model;
using Core.CrossCuttingConcerns.Exceptions;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ModelManager : IModelService
    {
        private readonly IModelDal _modelDal;
        private readonly ModelBusinessRules _businessRules;
        private IMapper _mapper;

        public ModelManager(IModelDal modelDal, ModelBusinessRules businessRules, IMapper mapper)
        {
            _modelDal = modelDal;
            _businessRules = businessRules;
            _mapper = mapper;
        }

        public AddModelResponse Add(AddModelRequest request)
        {
            _businessRules.CheckIfModelNameLength(request.Name);
            if (request.Name.Length < 2)
            {
                throw new BusinessException("Model name must be at least 2 characters.");
            }
            _businessRules.CheckIdDailyPriceValid(request.DailyPrice);
            if (request.DailyPrice <= 0)
            {
                throw new BusinessException("Model daily price must greater than 0.");
            }
            Model modelToAd = _mapper.Map<Model>(request);
            _modelDal.Add(modelToAd);
            AddModelResponse response = _mapper.Map<AddModelResponse>(modelToAd);
            return response;

        }

        public DeleteModelResponse Delete(int id)
        {
            Model modelToDelete = _businessRules.FindBrandId(id);

            modelToDelete.DeletedAt = DateTime.Now;
            DeleteModelResponse response = _mapper.Map<DeleteModelResponse>(modelToDelete);
            return response;
        }

        public GetModelListResponse GetList(GetModelListRequest request)
        {
            IList<Model> modelList = _modelDal.GetList();

            GetModelListResponse response = _mapper.Map<GetModelListResponse>(modelList);
            return response;
        }

        public UpdateModelResponse Update(int id, UpdateModelRequest request)
        {
            _businessRules.CheckIfModelNameLength(request.Name);
            if (request.Name.Length < 2)
            {
                throw new BusinessException("Model name must be at least 2 characters.");
            }
            _businessRules.CheckIdDailyPriceValid(request.DailyPrice);
            if (request.DailyPrice <= 0)
            {
                throw new BusinessException("Model daily price must greater than 0.");
            }
            Model modelToUpdate = _businessRules.FindBrandId(id);
            modelToUpdate.UpdatedAt = DateTime.Now;
            modelToUpdate.BrandId = request.BrandId;
            modelToUpdate.TransmissionId = request.TransmissionId;
            modelToUpdate.DailyPrice = request.DailyPrice;
            modelToUpdate.FuelId = request.FuelId;
            modelToUpdate.Name = request.Name;

            UpdateModelResponse response = _mapper.Map<UpdateModelResponse>(modelToUpdate);
            return response;
        }
    }
}
