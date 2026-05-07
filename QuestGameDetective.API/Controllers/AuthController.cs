using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.API.Services;
using QuestGameDetective.Application.Dtos.Auth;
using MediatR;
using QuestGameDetective.Application.Auth.Commands.Register;
using QuestGameDetective.Application.Auth.Commands.Login;

namespace QuestGameDetective.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
   

        public AuthController(
            IMediator mediator,
            UserManager<ApplicationUser> userManager,
            TokenService tokenService)
        {
            _mediator = mediator;
  
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterDto dto)
        {
            try
            {
                await _mediator.Send(new RegisterCommand(
                    dto.UserName,
                    dto.Email,
                    dto.Password));

                return Ok("User created");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginDto dto)
        {
            try
            {
                var token = await _mediator.Send(new LoginCommand(
                    dto.Email,
                    dto.Password));

                return Ok(token);
            }
            catch (Exception)
            {
                return Unauthorized("Invalid credentials");
            }
        }
    }



}