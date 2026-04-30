using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.API.Models;
using QuestGameDetective.API.Dtos.Users;

namespace QuestGameDetective.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize(Roles = "Admin")]
    public class AdminController : ControllerBase
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public AdminController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet("users")] // Admin kan hämta alla Users, så om listan är tom retuneras en tom array
        public async Task<ActionResult<List<UserReadDto>>> GetAllUsers()
        {
            var users = await _userManager.Users
                .OrderBy(u => u.UserName)  // för bättre organisering av listan innan den skickas till frontend
                .Select(u => new UserReadDto
                {
                    Id = u.Id,
                    UserName = u.UserName ?? "",
                    Email = u.Email ?? ""
                })
                .ToListAsync();

            return Ok(users);
        }
    }
}