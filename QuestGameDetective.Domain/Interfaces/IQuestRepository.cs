using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Domain.Interfaces;

public interface IQuestRepository
{
    Task<List<Quest>> GetUserQuestsAsync(string userId);
}