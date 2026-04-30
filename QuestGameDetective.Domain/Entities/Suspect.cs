namespace QuestGameDetective.Domain.Entities
{

    public class Suspect
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = "";
        public string Label { get; set; } = "";
        public string Statement { get; set; } = "";

        public Guid MurderCaseId { get; set; }
    }
}