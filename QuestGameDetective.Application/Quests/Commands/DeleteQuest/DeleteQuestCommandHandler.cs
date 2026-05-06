using MediatR;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Commands.DeleteQuest;

public class DeleteQuestCommandHandler
    : IRequestHandler<DeleteQuestCommand>
{
    private readonly IQuestRepository _questRepository;

    public DeleteQuestCommandHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task Handle(
        DeleteQuestCommand request,
        CancellationToken cancellationToken)
    {
        var quest = await _questRepository.GetUserQuestAsync(
            request.QuestId,
            request.UserId);

        if (quest == null)
            throw new Exception("Quest not found.");

        await _questRepository.DeleteAsync(quest);
    }
}