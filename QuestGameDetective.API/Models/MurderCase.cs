using QuestGameDetective.API.Models.Enums;
using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.API.Models
{
    public class MurderCase
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; } = "";
        public string ShortSummary { get; set; } = "";
        public string Victim { get; set; } = "";
        public string Place { get; set; } = "";

        public string CauseOfDeath { get; set; } = "";
        public string Weapon { get; set; } = "";
        public string CrimeSceneDescription { get; set; } = "";
        public string SolutionText { get; set; } = "";

        public CasePriority Priority { get; set; } = CasePriority.Medium;
        public int KillerIndex { get; set; } = -1;

        public List<Suspect> Suspects { get; set; } = new();
        public List<string> Clues { get; set; } = new(); // funkar för nu
    }
}