using QuestGameDetective.API.Dtos.Cases;
using QuestGameDetective.API.Models.Enums;

public class CaseReadDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = "";
    public string ShortSummary { get; set; } = "";
    public string Victim { get; set; } = "";
    public string Place { get; set; } = "";
    public string CauseOfDeath { get; set; } = "";
    public string Weapon { get; set; } = "";
    public string CrimeSceneDescription { get; set; } = "";

    public CasePriority Priority { get; set; }

    public List<SuspectDto> Suspects { get; set; } = new();
}