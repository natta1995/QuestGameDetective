using QuestGameDetective.Application.Interfaces;
using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Infrastructure.Repositories
{
    public class InMemoryQuestRepository : IQuestRepository
    {
        private readonly List<Quest> _items = new();

        public void Add(Quest quest) => _items.Add(quest);

        public IEnumerable<Quest> GetForUser(string username)
            => _items.Where(x => x.OwnerUsername == username);

        public void Update(Quest quest)
        {
            var existing = _items.FirstOrDefault(x => x.Id == quest.Id);
            if (existing is null) return;

            existing.Title = quest.Title;
            existing.Description = quest.Description;
            existing.OwnerUsername = quest.OwnerUsername;
            existing.Status = quest.Status;
            existing.Result = quest.Result;
            existing.AcceptedAt = quest.AcceptedAt;
            existing.ExpiresAt = quest.ExpiresAt;
            existing.Reminder20hSent = quest.Reminder20hSent;
            existing.Reminder1hSent = quest.Reminder1hSent;
            existing.CaseId = quest.CaseId;
        }
    }
}