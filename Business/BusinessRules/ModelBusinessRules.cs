using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.BusinessRules
{
    public class ModelBusinessRules
    {
        private readonly IModelDal _modelDal;
        public ModelBusinessRules(IModelDal modelDal)
        {
            _modelDal = modelDal;
        }
        public Model CheckIfModelNameLength(string modelName)
        {
            Model model = _modelDal.GetList().SingleOrDefault(m => m.Name == modelName);

            return model;

        }
        public Model CheckIdDailyPriceValid(decimal dailyPrice)
        {
            Model model = _modelDal.GetList().SingleOrDefault(m => m.DailyPrice == dailyPrice);
            return model;
        }
        public Model FindBrandId(int id)
        {
            Model model = _modelDal.GetList().SingleOrDefault(b => b.Id == id);
            return model;
        }
    }
}

