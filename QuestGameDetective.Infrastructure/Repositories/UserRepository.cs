
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Infrastructure.Repositories;

public class UserRepository : IUserRepository
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserRepository(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<List<ApplicationUser>> GetAllAsync()
    {
        return await _userManager.Users
            .OrderBy(u => u.UserName)
            .ToListAsync();
    }
}