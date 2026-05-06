using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Domain.Enums;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Commands.UpdateQuestResult;

public class UpdateQuestResultCommandHandler
    : IRequestHandler<UpdateQuestResultCommand, QuestReadDto>
{
    private readonly IQuestRepository _questRepository;

    public UpdateQuestResultCommandHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task<QuestReadDto> Handle(
        UpdateQuestResultCommand request,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrWhiteSpace(request.Result))
            throw new Exception("Result is required.");

        var quest = await _questRepository.GetUserQuestAsync(
            request.QuestId,
            request.UserId);

        if (quest == null)
            throw new Exception("Quest not found.");

        if (quest.Result != QuestResult.None)
            throw new Exception("Quest result is already set.");

        if (!Enum.TryParse<QuestResult>(request.Result, true, out var newResult))
            throw new Exception("Invalid result.");

        if (newResult == QuestResult.None)
            throw new Exception("Result cannot be None.");

        quest.Result = newResult;

        await _questRepository.SaveChangesAsync();

        return new QuestReadDto
        {
            Id = quest.Id,
            Status = quest.Status,
            Result = quest.Result,
            AcceptedAt = quest.AcceptedAt
        };
    }
}