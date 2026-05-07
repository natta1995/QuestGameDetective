using Microsoft.AspNetCore.Identity;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Infrastructure.Repositories;

public class AuthRepository : IAuthRepository
{
    private readonly UserManager<ApplicationUser> _userManager;

    public AuthRepository(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task RegisterAsync(string userName, string email, string password)
    {
        var user = new ApplicationUser
        {
            UserName = userName,
            Email = email
        };

        var result = await _userManager.CreateAsync(user, password);

        if (!result.Succeeded)
            throw new Exception(string.Join(", ", result.Errors.Select(e => e.Description)));

        await _userManager.AddToRoleAsync(user, "User");
    }
}