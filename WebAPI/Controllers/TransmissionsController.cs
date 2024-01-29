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
        [HttpPut("{Id}")]
        public ActionResult<UpdateTransmissionResponse> Update([FromRoute] int Id, [FromBody] UpdateTransmissionRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateTransmissionResponse response = _transmissionService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public DeleteTransmissionResponse Delete([FromRoute] DeleteTransmissionRequest request)
        {
            DeleteTransmissionResponse delete = _transmissionService.Delete(request);
            return delete;
        }
    }
}
