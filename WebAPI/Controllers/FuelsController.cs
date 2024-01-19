using Business;
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
            AddFuelResponse response = _fuelService.Add(request);
            //return response;//200 OK
            return CreatedAtAction(nameof(GetList), response); // 201 Created dönecek
        }
    }
}
