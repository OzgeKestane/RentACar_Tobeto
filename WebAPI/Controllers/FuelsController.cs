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
        [HttpPut("{Id}")]
        public ActionResult<UpdateFuelResponse> Update([FromRoute] int Id, [FromBody] UpdateFuelRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateFuelResponse response = _fuelService.Update(request);
            return Ok(response);

        }
        [HttpDelete("{Id}")]
        public DeleteFuelResponse Delete([FromRoute] DeleteFuelRequest request)
        {
            DeleteFuelResponse deleteFuelResponse = _fuelService.Delete(request);
            return deleteFuelResponse;

        }
    }
}
