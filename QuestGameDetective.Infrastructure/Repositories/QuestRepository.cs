using Microsoft.EntityFrameworkCore;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;
using QuestGameDetective.Infrastructure.Data;

namespace QuestGameDetective.Infrastructure.Repositories;

public class QuestRepository : IQuestRepository
{
    private readonly AppDbContext _context;

    public QuestRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Quest>> GetUserQuestsAsync(string userId)
    {
        return await _context.Quests
            .Include(q => q.MurderCase)
            .Where(q => q.UserId == userId)
            .ToListAsync();
    }
}