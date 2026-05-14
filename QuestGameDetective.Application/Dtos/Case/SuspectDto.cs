namespace QuestGameDetective.Application.Dtos.Case
{
    public class SuspectDto
    {
        public string Name { get; set; } = "";
        public string Role { get; set; } = "";
        public string Statement { get; set; } = "";

        public string SuspectImg { get; set; } = ""; // NEW

        public string InInvestigatorsNotes { get; set; } = ""; // NEW
    }
}

