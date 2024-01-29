using Business.Abstract;
using Business.Request.Brand;
using Business.Responses.Brand;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;
        public BrandsController(IBrandService brandService)
        {
            //Her Http Request için yeni bir Controller nesnesi oluşturulur.
            //şuan bir cilass açıp static yaptık, bu referansın 1 tane odluğunu söylüyor, sürekli newlemez ve veriyi tutar.
            _brandService = brandService;
            //ServiceRegistration.BrandService;
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
        public GetBrandListResponse GetList([FromQuery] GetBrandListRequest request)
        {
            GetBrandListResponse response = _brandService.GetList(request);
            return response; //JSON
        }

        //[HttpPost("/add")]//endpoint http://localhost:5031/api/brands/add
        [HttpPost] //POST http://localhost:5031/api/brands
        public ActionResult<AddBrandResponse> Add(AddBrandRequest request)
        {
            try
            {
                AddBrandResponse response = _brandService.Add(request);
                //return response;//200 OK
                return CreatedAtAction(nameof(GetList), response); // 201 Created dönecek
            }
            catch (Core.CrossCuttingConcerns.Exceptions.BusinessException exception)
            {
                return BadRequest(new Core.CrossCuttingConcerns.Exceptions.BusinessProblemDetails()
                {
                    Title = "Business Exceptions",
                    Status = StatusCodes.Status400BadRequest,
                    Detail = exception.Message,
                    Instance = HttpContext.Request.Path

                });
            }
        }
        [HttpPut("{Id}")]
        public ActionResult<UpdateBrandResponse> Update([FromRoute] int Id, [FromBody] UpdateBrandRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateBrandResponse response = _brandService.Update(request);
            return Ok(response);
        }

        [HttpDelete("{Id}")]
        public DeleteBrandResponse Delete([FromRoute] DeleteBrandRequest request)
        {
            DeleteBrandResponse deleteBrandResponse = _brandService.Delete(request);
            return deleteBrandResponse;

        }
    }
}

