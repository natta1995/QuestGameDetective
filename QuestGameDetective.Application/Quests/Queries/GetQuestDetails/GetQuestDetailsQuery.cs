using MediatR;
using QuestGameDetective.Application.Dtos.Quest;

namespace QuestGameDetective.Application.Quests.Queries.GetQuestDetails;

public record GetQuestDetailsQuery(Guid QuestId, string UserId)
    : IRequest<QuestCaseDetailDto?>;