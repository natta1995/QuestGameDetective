using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Queries.GetMyQuests;

public class GetMyQuestsQueryHandler
    : IRequestHandler<GetMyQuestsQuery, List<MyQuestDto>>
{
    private readonly IQuestRepository _questRepository;

    public GetMyQuestsQueryHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task<List<MyQuestDto>> Handle(
        GetMyQuestsQuery request,
        CancellationToken cancellationToken)
    {
        var quests = await _questRepository.GetUserQuestsAsync(request.UserId);

        return quests.Select(q => new MyQuestDto
        {
            QuestId = q.Id,
            MurderCaseId = q.MurderCaseId,
            Title = q.MurderCase.Title,
            ShortSummary = q.MurderCase.ShortSummary,
            Status = q.Status,
            Result = q.Result,
            AcceptedAt = q.AcceptedAt
        }).ToList();
    }
}