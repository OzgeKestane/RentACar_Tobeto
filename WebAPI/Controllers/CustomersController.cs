using Business.Abstract;
using Business.Request.Customer;
using Business.Responses.Customer;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet] //GET http://localhost:5245/api/customer
        public GetCustomerListResponse GetList([FromQuery] GetCustomerListRequest request)
        {
            GetCustomerListResponse response = _customerService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        //GET http://localhost:5245/api/customer/1
        public GetCustomerByIdResponse GetById([FromRoute] GetCustomerByIdRequest request)
        {
            GetCustomerByIdResponse response = _customerService.GetById(request);
            return response;
        }
        [HttpPost] //POST http://localhost:5245/api/customer
        public ActionResult<AddCustomerResponse> Add(AddCustomerRequest request)
        {
            AddCustomerResponse response = _customerService.Add(request);
            return CreatedAtAction(
                actionName: nameof(GetById), routeValues: new { Id = response.Id }, value: response);
        }
        [HttpPut("{Id}")] //PUT http://localhost:5245/api/customer/1
        public ActionResult<UpdateCustomerResponse> Update([FromRoute] int Id, [FromBody] UpdateCustomerRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateCustomerResponse response = _customerService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")] //DELETE http://localhost:5245/api/customer/1
        public DeleteCustomerResponse Delete([FromRoute] DeleteCustomerRequest request)
        {
            DeleteCustomerResponse response = _customerService.Delete(request);
            return response;
        }

    }
}
