using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<List<ApplicationUser>> GetAllAsync();
    }
}
