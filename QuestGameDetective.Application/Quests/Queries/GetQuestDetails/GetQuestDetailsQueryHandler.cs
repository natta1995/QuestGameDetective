using MediatR;
using QuestGameDetective.Application.Dtos.Cases;
using QuestGameDetective.Application.Dtos.Quests;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Queries.GetQuestDetails;

public class GetQuestDetailsQueryHandler
    : IRequestHandler<GetQuestDetailsQuery, QuestCaseDetailDto?>
{
    private readonly IQuestRepository _questRepository;

    public GetQuestDetailsQueryHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task<QuestCaseDetailDto?> Handle(
        GetQuestDetailsQuery request,
        CancellationToken cancellationToken)
    {
        var quest = await _questRepository.GetQuestDetailsAsync(
            request.QuestId,
            request.UserId);

        if (quest == null)
            return null;

        return new QuestCaseDetailDto
        {
            QuestId = quest.Id,
            MurderCaseId = quest.MurderCaseId,
            Title = quest.MurderCase.Title,
            ShortSummary = quest.MurderCase.ShortSummary,
            Victim = quest.MurderCase.Victim,
            Place = quest.MurderCase.Place,
            CauseOfDeath = quest.MurderCase.CauseOfDeath,
            Weapon = quest.MurderCase.Weapon,
            CrimeSceneDescription = quest.MurderCase.CrimeSceneDescription,
            Status = quest.Status,
            Result = quest.Result,
            Suspects = quest.MurderCase.Suspects.Select(s => new SuspectDto
            {
                Name = s.Name,
                Statement = s.Statement
            }).ToList()
        };
    }
}