using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Application.Interfaces
{
    public interface IQuestRepository
    {
        void Add(Quest quest);
        void Update(Quest quest);
        IEnumerable<Quest> GetForUser(string username);
    }
}