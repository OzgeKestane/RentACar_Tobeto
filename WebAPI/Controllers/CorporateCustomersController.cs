using Business.Abstract;
using Business.Request.CorporateCustomer;
using Business.Responses.CorporateCustomer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CorporateCustomersController : ControllerBase
    {
        private readonly ICorporateCustomerService _corporateCustomerService;

        public CorporateCustomersController(ICorporateCustomerService corporateCustomerService)
        {
            _corporateCustomerService = corporateCustomerService;
        }
        [HttpGet]
        public GetCorporateListResponse GetList([FromQuery] GetCorporateListRequest request)
        {
            GetCorporateListResponse response = _corporateCustomerService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        public GetCorporateByIdResponse GetById([FromRoute] GetCorporateByIdRequest request)
        {
            GetCorporateByIdResponse response = _corporateCustomerService.GetById(request);
            return response;
        }
        [HttpPost]
        public ActionResult<AddCorporateResponse> Add(AddCorporateRequest request)
        {
            AddCorporateResponse response = _corporateCustomerService.Add(request);
            return CreatedAtAction(actionName: nameof(GetById), routeValues: new { response.Id }, value: response);
        }
        [HttpPut("{Id}")]
        public ActionResult<UpdateCorporateResponse> Update([FromRoute] int Id, [FromBody] UpdateCorporateRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateCorporateResponse response = _corporateCustomerService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")]
        public DeleteCorporateResponse Delete(DeleteCorporateRequest request)
        {
            DeleteCorporateResponse response = _corporateCustomerService.Delete(request);
            return response;
        }
    }
}
