using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Application.Dtos.Quests;

namespace QuestGameDetective.Application.Quests.Commands.UpdateQuestResult;

public record UpdateQuestResultCommand(
    Guid QuestId,
    string UserId,
    string Result
) : IRequest<QuestReadDto>;