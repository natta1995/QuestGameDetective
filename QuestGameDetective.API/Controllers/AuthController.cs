using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.API.Services;
using QuestGameDetective.Application.Dtos.Auth;
using MediatR;
using QuestGameDetective.Application.Auth.Commands.Register;

namespace QuestGameDetective.API.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly TokenService _tokenService;

        public AuthController(
            IMediator mediator,
            UserManager<ApplicationUser> userManager,
            TokenService tokenService)
        {
            _mediator = mediator;
            _userManager = userManager;
            _tokenService = tokenService;
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
            var user = await _userManager.FindByEmailAsync(dto.Email);

            if (user == null)
                return Unauthorized("Invalid credentials");

            var validPassword = await _userManager.CheckPasswordAsync(user, dto.Password);

            if (!validPassword)
                return Unauthorized("Invalid credentials");

            var token = await _tokenService.CreateToken(user);

            return Ok(token);
        }
    }



}