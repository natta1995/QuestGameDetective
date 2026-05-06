using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Application.Dtos.Quests;

namespace QuestGameDetective.Application.Quests.Commands.AcceptQuest;

public record AcceptQuestCommand(Guid CaseId, string UserId) : IRequest<QuestAcceptedDto>;