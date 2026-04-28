using QuestGameDetective.API.Models.Enums;

public class QuestReadDto
{
    public Guid Id { get; set; }

    public QuestStatus Status { get; set; }
    public QuestResult Result { get; set; }

    public DateTime? AcceptedAt { get; set; }

   // public DateTime? CompletedAt { get; set; }
}