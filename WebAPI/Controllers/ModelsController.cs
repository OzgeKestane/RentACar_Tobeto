using Business.Abstract;
using Business.Request.Model;
using Business.Responses.Model;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModelsController : ControllerBase
    {
        private readonly IModelService _modelService;
        public ModelsController(IModelService modelService)
        {
            _modelService = modelService;
        }
        [HttpGet]
        public GetModelListResponse GetList([FromQuery] GetModelListRequest request)
        {
            GetModelListResponse response = _modelService.GetList(request);
            return response;
        }
        [HttpPost]
        public ActionResult<AddModelResponse> Add(AddModelRequest request)
        {
            try
            {
                AddModelResponse response = _modelService.Add(request);

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


        }
        [HttpPut("{id}")]
        public UpdateModelResponse Update(UpdateModelRequest request, int id)
        {
            UpdateModelResponse response = _modelService.Update(id, request);
            return response;
        }
        [HttpDelete("{id}")]
        public DeleteModelResponse Delete(int id)
        {
            DeleteModelResponse response = _modelService.Delete(id);
            return response;
        }

    }
}
