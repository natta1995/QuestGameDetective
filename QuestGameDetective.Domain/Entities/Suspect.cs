namespace QuestGameDetective.Domain.Entities
{

    public class Suspect
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
        public string Statement { get; set; } = "";

        public string SuspectImg { get; set; } = ""; // NEW

        public string InInvestigatorsNotes { get; set; } = ""; // NEW

        public Guid MurderCaseId { get; set; }
    }
}