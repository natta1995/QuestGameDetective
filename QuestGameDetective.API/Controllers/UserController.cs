using QuestGameDetective.Application.Dtos.User;
using QuestGameDetective.Application.Users.Queries.GetAllUsers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MediatR;


namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("users")]
        public async Task<ActionResult<List<UserReadDto>>> GetAllUsers()
        {
            var users = await _mediator.Send(new GetAllUsersQuery());

            return Ok(users);
        }
    }
}