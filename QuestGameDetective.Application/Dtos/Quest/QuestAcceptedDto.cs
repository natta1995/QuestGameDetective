using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Application.Dtos.Quest
{
    public class QuestAcceptedDto
    {
        public string Message { get; set; } = "";
        public Guid QuestId { get; set; }
        public Guid MurderCaseId { get; set; }
        public QuestStatus Status { get; set; }
        public QuestResult Result { get; set; }
        public DateTime? AcceptedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
    }
}