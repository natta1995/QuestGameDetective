using MediatR;
using QuestGameDetective.Application.Dtos.Quest;

namespace QuestGameDetective.Application.Quests.Commands.UpdateQuestResult;

public record UpdateQuestResultCommand(
    Guid QuestId,
    string UserId,
    int SuspectIndex
    ) : IRequest<AccuseSuspectResultDto>;