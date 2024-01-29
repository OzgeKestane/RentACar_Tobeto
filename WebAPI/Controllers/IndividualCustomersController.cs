using Business.Abstract;
using Business.Request.IndividualCustomer;
using Business.Responses.IndividualCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IndividualCustomersController : ControllerBase
    {
        private readonly IIndividualCustomerService _individualCustomerService;

        public IndividualCustomersController(IIndividualCustomerService individualCustomerService)
        {
            _individualCustomerService = individualCustomerService;
        }
        [HttpGet]
        public GetIndividualListResponse GetList([FromQuery] GetIndividualListRequest request)
        {
            GetIndividualListResponse response = _individualCustomerService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        public GetIndividualByIdResponse GetById([FromRoute] GetIndividualByIdRequest request)
        {
            GetIndividualByIdResponse response = _individualCustomerService.GetById(request);
            return response;
        }
        [HttpPost]
        public ActionResult<AddIndividualResponse> Add(AddIndividualRequest request)
        {
            AddIndividualResponse response = _individualCustomerService.Add(request);
            return CreatedAtAction(actionName: nameof(GetById), routeValues: new { response.Id }, value: response);
        }
        [HttpPut("{Id}")]
        public ActionResult<UpdateIndividualResponse> Update([FromRoute] int Id, [FromBody] UpdateIndividualRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateIndividualResponse response = _individualCustomerService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public DeleteIndividualResponse Delete([FromRoute] DeleteIndividualRequest request)
        {
            DeleteIndividualResponse response = _individualCustomerService.Delete(request);
            return response;
        }

    }
}
