using Business.Abstract;
using Business.Request.Fuel;
using Business.Responses.Fuel;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private readonly IFuelService _fuelService;
        public FuelsController(IFuelService fuelService)
        {
            _fuelService = fuelService;
        }

        [HttpGet]
        public GetFuelListResponse GetList([FromQuery] GetFuelListRequest request)
        {
            GetFuelListResponse response = _fuelService.GetList(request);
            return response;
        }

        [HttpPost]


        public ActionResult<AddFuelResponse> Add(AddFuelRequest request)
        {
            try
            {
                AddFuelResponse response = _fuelService.Add(request);
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
        [HttpPut("{id}")]
        public UpdateFuelResponse Update(UpdateFuelRequest request, int id)
        {
            UpdateFuelResponse update = _fuelService.Update(id, request);
            return update;

        }
        [HttpDelete("{id}")]
        public DeleteFuelResponse Delete(int id)
        {
            DeleteFuelResponse delete = _fuelService.Delete(id);
            return delete;
        }
    }
}
