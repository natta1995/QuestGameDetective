using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Domain.Entities
{


    public class Case
    {
        public string Id { get; set; } = "";
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
        public List<string> Clues { get; set; } = new();

    }
}
