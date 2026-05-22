using QuestGameDetective.Application.Dtos.Case;
using QuestGameDetective.Domain.Enums;
using System.Security.Cryptography.X509Certificates;

namespace QuestGameDetective.Application.Dtos.Quest
{
    public class QuestCaseDetailDto
    {
        public Guid QuestId { get; set; }
        public Guid MurderCaseId { get; set; }

        // 🕵️ Mordfallet
        public string Title { get; set; } = string.Empty;
        public string ShortSummary { get; set; } = string.Empty;
        public string Victim { get; set; } = string.Empty;

        public string VictimAge { get; set; } = string.Empty;

        public string VictimJob { get; set; } = string.Empty;

        public string VictimLifeSituation { get; set; } = string.Empty;
        public string Place { get; set; } = string.Empty;
        public string CauseOfDeath { get; set; } = string.Empty;
        public string Weapon { get; set; } = string.Empty;
        public string CrimeSceneDescription { get; set; } = string.Empty;

        public string VictimImg { get; set; } = "";
        public string CrimeSceneImg { get; set; } = "";

        public string CrimeSceneImgText { get; set; } = "";
        public string ClueImg { get; set; } = "";
        public string ClueImgText { get; set; } = "";

        public string SecondClueImg { get; set; } = "";

        public string SecondClueImgText { get; set; } = "";

        // 🎮 Spelarens progress
        public QuestStatus Status { get; set; }
        public QuestResult Result { get; set; }

        // 👤 Suspects
        public List<SuspectDto> Suspects { get; set; } = new();
    }
}