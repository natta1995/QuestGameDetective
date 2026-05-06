using QuestGameDetective.Domain.Enums; 

namespace QuestGameDetective.Application.Dtos.Quest
{
    public class QuestReadDto
    {
        public Guid Id { get; set; }

        public QuestStatus Status { get; set; }
        public QuestResult Result { get; set; }

        public DateTime? AcceptedAt { get; set; }
    }
}