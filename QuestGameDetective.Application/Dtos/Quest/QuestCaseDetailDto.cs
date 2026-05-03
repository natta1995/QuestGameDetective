using QuestGameDetective.Application.Dtos.Cases;
using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Application.Dtos.Quests
{
    public class QuestCaseDetailDto
    {
        public Guid QuestId { get; set; }
        public Guid MurderCaseId { get; set; }

        // 🕵️ Mordfallet
        public string Title { get; set; } = string.Empty;
        public string ShortSummary { get; set; } = string.Empty;
        public string Victim { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public string CauseOfDeath { get; set; } = string.Empty;
        public string Weapon { get; set; } = string.Empty;
        public string CrimeSceneDescription { get; set; } = string.Empty;

        // 🎮 Spelarens progress
        public QuestStatus Status { get; set; }
        public QuestResult Result { get; set; }

        // 👤 Suspects
        public List<SuspectDto> Suspects { get; set; } = new();
    }
}