using Business.Abstract;
using Business.Request.Transmission;
using Business.Responses.Transmission;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransmissionsController : ControllerBase
    {
        public readonly ITransmissionService _transmissionService;
        public TransmissionsController(ITransmissionService service)
        {
            _transmissionService = service;
        }
        [HttpGet]
        public GetTransmissionListResponse GetList([FromQuery] GetTransmissionListRequest request)
        {
            GetTransmissionListResponse response = _transmissionService.GetList(request);
            return response;

        }
        [HttpPost]
        public ActionResult<AddTransmissionResponse> Add(AddTransmissionRequest request)
        {
            try
            {
                AddTransmissionResponse response = _transmissionService.Add(request);

                return CreatedAtAction(nameof(GetList), response);
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
            //AddTransmissionResponse response = _transmissionService.Add(request);
            //return CreatedAtAction("GetList", response);
        }
        [HttpPut("{id}")]
        public UpdateTransmissionResponse Update(UpdateTransmissionRequest request, int id)
        {
            UpdateTransmissionResponse update = _transmissionService.Update(id, request);
            return update;
        }
        [HttpDelete("{id}")]
        public DeleteTransmissionResponse Delete(int id)
        {
            DeleteTransmissionResponse delete = _transmissionService.Delete(id);
            return delete;
        }
    }
}
