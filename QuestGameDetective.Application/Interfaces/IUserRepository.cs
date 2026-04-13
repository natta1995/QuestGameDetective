using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Application.Interfaces
{
    public interface IUserRepository
    {
        void Create(User user);
        User? FindByUsername(string username);
        void Update(User user);
    }
}