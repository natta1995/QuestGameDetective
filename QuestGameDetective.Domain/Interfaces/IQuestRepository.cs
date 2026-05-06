using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Domain.Interfaces;

public interface IQuestRepository
{
    Task<List<Quest>> GetUserQuestsAsync(string userId);

    Task<bool> MurderCaseExistsAsync(Guid caseId);

    Task<bool> UserAlreadyAcceptedCaseAsync(string userId, Guid caseId);

    Task<Quest> AddAsync(Quest quest);

    Task<Quest?> GetQuestDetailsAsync(Guid questId, string userId);

    Task<Quest?> GetUserQuestAsync(Guid questId, string userId);

    Task SaveChangesAsync();
}