using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Domain.Entities
{

    public class Quest
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string UserId { get; set; } = "";
        public Guid MurderCaseId { get; set; }

        public QuestStatus Status { get; set; } = QuestStatus.Accepted;
        public QuestResult Result { get; set; } = QuestResult.None;

        public DateTime AcceptedAt { get; set; } = DateTime.UtcNow;
        public DateTime? ExpiresAt { get; set; }

        public bool Reminder20hSent { get; set; } = false;
        public bool Reminder1hSent { get; set; } = false;

        public bool IsExpired => ExpiresAt.HasValue && DateTime.UtcNow > ExpiresAt.Value;
    }
}