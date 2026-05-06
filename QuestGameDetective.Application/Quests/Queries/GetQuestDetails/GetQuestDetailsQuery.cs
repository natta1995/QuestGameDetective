using MediatR;
using QuestGameDetective.Application.Dtos.Quests;

namespace QuestGameDetective.Application.Quests.Queries.GetQuestDetails;

public record GetQuestDetailsQuery(Guid QuestId, string UserId)
    : IRequest<QuestCaseDetailDto?>;