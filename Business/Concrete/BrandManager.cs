using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;
        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper)
        {
            _brandDal = brandDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
        }

        public AddBrandResponse Add(AddBrandRequest request)
        { //İş kuralları
            _brandBusinessRules.CheckIfBrandNameExists(request.Name);

            //validation
            //yetki kontrolü 
            //Cache
            //Transaction vs..
            // Brand addedBrand=

            Brand brandToAdd = _mapper.Map<Brand>(request);   //mapping    //new(request.name) elle newlemek yerine mappleme özelliğini kullanıyoruz.          
            _brandDal.Add(brandToAdd);

            //Mapping
            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;
        }

        public IList<Brand> GetList()
        {
            //İş kodları
            //validation
            //yetki kontrolü 
            //Cache
            //Transaction vs..
            IList<Brand> brandList = _brandDal.GetList();
            return brandList;
        }

        //AddBrandResponse IBrandService.Add(AddBrandRequest request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
