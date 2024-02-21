using AutoMapper;
using Business.Abstract;
using Business.BusinessRules;
using Business.Request.Brand;
using Business.Responses.Brand;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal; //bir entity service'i kendi entitysi dışında hiç bir entitynin DAL'ını enjekte etmemelidir.
        private readonly BrandBusinessRules _brandBusinessRules;
        private IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BrandManager(IBrandDal brandDal, BrandBusinessRules brandBusinessRules, IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _brandDal = brandDal;//new InMemoryDal(); // başka katmanların classları newlenmez. bu yüzden dependency injection 
            _brandBusinessRules = brandBusinessRules;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        // AOP => Aspect Oriented Programming
        // Pipeline
        //mediatr , pipeline , cqrs
        //Auth&Authorization
        //role  implementasyonu => Claimlere kullanıcı rollerini db'den ekleyip gelen isteklerde
        // rol bazlı kontrol yapılması
        public AddBrandResponse Add(AddBrandRequest request)
        { //İş kuralları
            if (!_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated) //kullanıcı yoksa
            {
                throw new Exception("Bu endpointi çalıştırmak için giriş yapmak zorundasınız");
            }
            _brandBusinessRules.CheckIfBrandNameExists(request.Name);

            //validation
            //Authentication-Authorization
            //Cache
            //Transaction vs..
            // 

            Brand brandToAdd = _mapper.Map<Brand>(request);   //mapping    //new(request.name) elle newlemek yerine mappleme özelliğini kullanıyoruz.         //aynı işlemde eşleşen kısımları, Brand nesnesinde oluşturuyor  
            _brandDal.Add(brandToAdd);

            //Mapping
            AddBrandResponse response = _mapper.Map<AddBrandResponse>(brandToAdd);
            return response;
        }



        public DeleteBrandResponse Delete(DeleteBrandRequest request)
        {
            Brand? brandToDelete = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            _brandBusinessRules.CheckIfBrandExists(brandToDelete);
            Brand deletedBrand = _brandDal.Delete(brandToDelete!);
            DeleteBrandResponse response = _mapper.Map<DeleteBrandResponse>(deletedBrand);
            return response;
        }

        public GetBrandListResponse GetList(GetBrandListRequest request)
        {
            //İş kodları
            //validation
            //yetki kontrolü 
            //Cache
            //Transaction vs..
            IList<Brand> brandList = _brandDal.GetList();
            //Brand -> BrandListItemDto
            //IList<BrandListItemDto> -> GetBrandListResponseList<BrandListItemDto>
            //brandList.Items diye bir alan yok bu yüzden mapping yapılacak

            GetBrandListResponse response = _mapper.Map<GetBrandListResponse>(brandList);
            return response;
        }
        public Brand? GetById(int id)
        {
            return _brandDal.Get(i => i.Id == id);
        }



        public UpdateBrandResponse Update(UpdateBrandRequest request)
        {

            Brand? BrandToUpdate = _brandDal.Get(predicate: brand => brand.Id == request.Id);
            //_brandBusinessRules.CheckIfBrandExists(BrandToUpdate);

            BrandToUpdate = _mapper.Map(request, BrandToUpdate);
            Brand updatedBrand = _brandDal.Update(BrandToUpdate!);
            var response = _mapper.Map<UpdateBrandResponse>(updatedBrand);
            return response;
        }
        //AddBrandResponse IBrandService.Add(AddBrandRequest request)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
