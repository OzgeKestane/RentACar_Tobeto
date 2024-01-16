using Business.Abstract;
using Business.Request.Transmission;
using Business.Responses.Transmission;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        public readonly ITransmissionService _transmissionService;
        public TransmissionsController()
        {
            _transmissionService = TransmissionServiceRegistration.TransmissionService;
        }
        [HttpGet]
        public ICollection<Transmission> GetList()
        {
            IList<Transmission> list = _transmissionService.GetList();
            return list;

        }
        [HttpPost]
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            AddTransmissionResponse response = _transmissionService.Add(request);
            return CreatedAtAction("GetList", response);
        }

    }
}
