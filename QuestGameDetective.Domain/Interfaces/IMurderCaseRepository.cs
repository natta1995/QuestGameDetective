using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Domain.Interfaces
{
    public interface IMurderCaseRepository
    {
        Task<List<MurderCase>> GetAllAsync();
        Task<MurderCase?> GetByIdAsync(Guid id);
    }
}
