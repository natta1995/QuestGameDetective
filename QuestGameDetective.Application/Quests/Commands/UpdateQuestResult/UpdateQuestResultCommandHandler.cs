using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Domain.Enums;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Commands.UpdateQuestResult;

public class UpdateQuestResultCommandHandler
    : IRequestHandler<UpdateQuestResultCommand, AccuseSuspectResultDto>
{
    private readonly IQuestRepository _questRepository;

    public UpdateQuestResultCommandHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task<AccuseSuspectResultDto> Handle(
        UpdateQuestResultCommand request,
        CancellationToken cancellationToken)
    {
        var quest = await _questRepository.GetUserQuestWithCaseAsync(
            request.QuestId,
            request.UserId);

        if (quest == null)
            throw new Exception("Quest not found.");

        if (quest.Result != QuestResult.None)
            throw new Exception("Quest result is already set.");

        var isCorrect = request.SuspectIndex == quest.MurderCase.KillerIndex;

        quest.Result = isCorrect
            ? QuestResult.Solved
            : QuestResult.Failed;

        await _questRepository.SaveChangesAsync();

        return new AccuseSuspectResultDto
        {
            IsCorrect = isCorrect,
            Result = quest.Result,
            SolutionText = quest.MurderCase.SolutionText
        };
    }
}