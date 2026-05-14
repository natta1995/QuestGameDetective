using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Domain.Entities
{

    public class MurderCase
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = "";
        public string ShortSummary { get; set; } = "";
        public string Victim { get; set; } = "";
        public string Place { get; set; } = "";
        public string CauseOfDeath { get; set; } = "";
        public string Weapon { get; set; } = "";
        public string CrimeSceneDescription { get; set; } = "";
        public string SolutionText { get; set; } = "";

        // Img 

        public string VictimImg { get; set; } = "";
        public string CrimeSceneImg { get; set; } = "";
        public string ClueImg { get; set; } = "";



        public CasePriority Priority { get; set; } = CasePriority.Medium;
        public int KillerIndex { get; set; } = -1;

        public List<Suspect> Suspects { get; set; } = new();

    }
}