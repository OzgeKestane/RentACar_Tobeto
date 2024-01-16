using Business.Abstract;
using Business.Request.Brand;
using Business.Responses.Brand;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelsController : ControllerBase
    {
        private readonly IFuelService _fuelService;
        public FuelsController()
        {
            _fuelService = FuelServiceRegistration.FuelService;
        }

        [HttpGet]
        public ICollection<Fuel> GetList()
        {
            IList<Fuel> fuelList = _fuelService.GetList();
            return fuelList;
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
