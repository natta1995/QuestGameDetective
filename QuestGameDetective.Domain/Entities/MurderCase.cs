using QuestGameDetective.Domain.Enums;

namespace QuestGameDetective.Domain.Entities
{

    public class MurderCase
    {
        public Guid Id { get; set; }

        public string Title { get; set; } = "";
        public string ShortSummary { get; set; } = "";
        public string Victim { get; set; } = "";
        public string VictimAge { get; set; } = "";
        public string VictimJob { get; set; } = "";

        public string VictimLifeSituation { get; set; } = "";
        public string Place { get; set; } = "";
        public string CauseOfDeath { get; set; } = "";
        public string Weapon { get; set; } = "";
        public string CrimeSceneDescription { get; set; } = "";
        public string SolutionText { get; set; } = "";
        public string SolutionClues { get; set; } = "";

        // Img 

        public string VictimImg { get; set; } = "";
        public string CrimeSceneImg { get; set; } = "";

        public string CrimeSceneImgText { get; set; } = "";
        public string ClueImg { get; set; } = "";

        public string ClueImgText { get; set; } = "";

        public string SecondClueImg { get; set; } = "";
        public string SecondClueImgText { get; set; } = "";



        public CasePriority Priority { get; set; } = CasePriority.Medium;
        public int KillerIndex { get; set; } = -1;

        public List<Suspect> Suspects { get; set; } = new();

    }
}