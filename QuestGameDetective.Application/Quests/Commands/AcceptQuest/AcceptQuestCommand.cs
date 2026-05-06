using MediatR;
using QuestGameDetective.Application.Dtos.Quest;

namespace QuestGameDetective.Application.Quests.Commands.AcceptQuest;

public record AcceptQuestCommand(Guid CaseId, string UserId) : IRequest<QuestAcceptedDto>;