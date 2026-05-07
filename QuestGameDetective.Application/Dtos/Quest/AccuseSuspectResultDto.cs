using QuestGameDetective.Domain.Enums;


namespace QuestGameDetective.Application.Dtos.Quest
{
    public class AccuseSuspectResultDto
    {
        public bool IsCorrect { get; set; }
        public QuestResult Result { get; set; }

        public string SolutionText { get; set; } = "";
    }
}
