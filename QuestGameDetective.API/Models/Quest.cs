using QuestGameDetective.API.Models.Enums;

namespace QuestGameDetective.API.Models
{
    public class Quest
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = "";
        public string Description { get; set; } = "";

        public string UserId { get; set; } = ""; // koppling till Identity user

        public Guid MurderCaseId { get; set; } // koppling till case

        public QuestStatus Status { get; set; } = QuestStatus.Available;
        public QuestResult Result { get; set; } = QuestResult.None;

        public DateTime? AcceptedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }

        public bool Reminder20hSent { get; set; } = false;
        public bool Reminder1hSent { get; set; } = false;

        public bool IsExpired => ExpiresAt.HasValue && DateTime.Now > ExpiresAt.Value;
    }
}