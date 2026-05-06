using MediatR;

namespace QuestGameDetective.Application.Quests.Commands.DeleteQuest;

public record DeleteQuestCommand(Guid QuestId, string UserId) : IRequest;