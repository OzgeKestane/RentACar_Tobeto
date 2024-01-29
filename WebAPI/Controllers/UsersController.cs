using Business.Abstract;
using Business.Request.User;
using Business.Responses.User;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet] //GET http://localhost:5245/api/users
        public GetUserListResponse GetList([FromQuery] GetUserListRequest request)
        {
            GetUserListResponse response = _userService.GetList(request);
            return response;
        }
        [HttpGet("{Id}")]
        //GET http://localhost:5245/api/users/1
        public GetUserByIdResponse GetById([FromRoute] GetUserByIdRequest request)
        {
            GetUserByIdResponse response = _userService.GetById(request);
            return response;
        }
        [HttpPost] //POST http://localhost:5245/api/users
        public ActionResult<AddUserResponse> Add(AddUserRequest request)
        {
            AddUserResponse response = _userService.Add(request);
            return CreatedAtAction(//201 Created
                actionName: nameof(GetById), routeValues: new { Id = response.Id }, value: response);
        }
        [HttpPut("{Id}")] //PUT http://localhost:5245/api/users/1
        public ActionResult<UpdateUserResponse> Update([FromRoute] int Id, [FromBody] UpdateUserRequest request)
        {
            if (Id != request.Id)
                return BadRequest();
            UpdateUserResponse response = _userService.Update(request);
            return Ok(response);
        }
        [HttpDelete("{Id}")] //DELETE http://localhost:5245/api/user/1
        public DeleteUserResponse Delete([FromRoute] DeleteUserRequest request)
        {
            DeleteUserResponse response = _userService.Delete(request);
            return response;
        }
    }
}
