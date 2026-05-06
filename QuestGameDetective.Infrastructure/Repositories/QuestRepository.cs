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

    public async Task<bool> MurderCaseExistsAsync(Guid caseId)
    {
        return await _context.MurderCases
            .AnyAsync(c => c.Id == caseId);
    }

    public async Task<bool> UserAlreadyAcceptedCaseAsync(string userId, Guid caseId)
    {
        return await _context.Quests
            .AnyAsync(q => q.UserId == userId && q.MurderCaseId == caseId);
    }

    public async Task<Quest> AddAsync(Quest quest)
    {
        _context.Quests.Add(quest);

        await _context.SaveChangesAsync();

        return quest;
    }

    public async Task<Quest?> GetQuestDetailsAsync(Guid questId, string userId)
    {
        return await _context.Quests
            .Include(q => q.MurderCase)
                .ThenInclude(m => m.Suspects)
            .FirstOrDefaultAsync(q => q.Id == questId && q.UserId == userId);
    }

    public async Task<Quest?> GetUserQuestAsync(Guid questId, string userId)
    {
        return await _context.Quests
            .FirstOrDefaultAsync(q => q.Id == questId && q.UserId == userId);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}