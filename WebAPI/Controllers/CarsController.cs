using Business.Abstract;
using Business.Request.Car;
using Business.Responses.Car;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarService _carService;

        public CarsController(ICarService carService)
        {
            _carService = carService;
        }
        [HttpGet]
        public GetCarListResponse GetList([FromQuery] GetCarListRequest request)
        {
            GetCarListResponse response = _carService.GetList(request);
            return response;
        }
        [HttpPost]
        public ActionResult<AddCarResponse> Add(AddCarRequest request)
        {

            try
            {
                AddCarResponse response = _carService.Add(request);
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
        public ActionResult<UpdateCarResponse> UpdateCar([FromRoute] int Id, [FromBody] UpdateCarRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateCarResponse response = _carService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public DeleteCarResponse Delete([FromRoute] DeleteCarRequest request)
        {
            DeleteCarResponse response = _carService.Delete(request);
            return response;
        }
    }
}
