using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Application.Dtos.Quest
{
    public class MyQuestDto
    {
        public Guid QuestId { get; set; }
        public Guid MurderCaseId { get; set; }

        public string Title { get; set; } = string.Empty;
        public string ShortSummary { get; set; } = string.Empty;

        public QuestStatus Status { get; set; }
        public QuestResult Result { get; set; }

        public DateTime? AcceptedAt { get; set; }
    }
}
