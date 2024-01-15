using Business.Abstract;
using Business.Request.Brand;
using Business.Responses.Brand;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController()
        {
            //Her Http Request için yeni bir Controller nesnesi oluşturulur.
            //şuan bir class açıp static yaptık, bu referansın 1 tane odluğunu söylüyor, sürekli newlemez ve veriyi tutar.
            _brandService = ServiceRegistration.BrandService;
            //IBrandDal brandDal = new InMemoryBrandDal();
            //_brandService = new BrandManager(brandDal);// Daha sonra IoC yapısını kurduğumuzda dependency injection ile daha verimli hale getiricez.
        }

        //[HttpGet]

        //public IActionResult GetList()
        //{
        //    return Ok("Brands Controller");
        //} //burada sadece succes dşyor çalışınca parametre döndürmesi için aşağıdaki gibi
        //[HttpGet]

        //public ActionResult<string>
        //    GerList()
        //{
        //    return Ok("Brands Controller");
        //}
        //sadece 200 dönecekse
        [HttpGet]
        public ICollection<Brand> GetList()
        {
            IList<Brand> brandList = _brandService.GetList();
            return brandList; //JSON
        }

        //[HttpPost("/add")]//endpoint http://localhost:5031/api/brands/add
        [HttpPost] //POST http://localhost:5031/api/brands
        public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
        {
            AddBrandResponse response = _brandService.Add(request);
            //return response;//200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created dönecek
        }
    }
}
