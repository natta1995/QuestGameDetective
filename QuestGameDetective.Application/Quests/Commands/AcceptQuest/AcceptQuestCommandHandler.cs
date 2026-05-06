using MediatR;
using QuestGameDetective.Application.Dtos.Quest;
using QuestGameDetective.Application.Dtos.Quests;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Enums;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Quests.Commands.AcceptQuest;

public class AcceptQuestCommandHandler
    : IRequestHandler<AcceptQuestCommand, QuestAcceptedDto>
{
    private readonly IQuestRepository _questRepository;

    public AcceptQuestCommandHandler(IQuestRepository questRepository)
    {
        _questRepository = questRepository;
    }

    public async Task<QuestAcceptedDto> Handle(
        AcceptQuestCommand request,
        CancellationToken cancellationToken)
    {
        var caseExists = await _questRepository.MurderCaseExistsAsync(request.CaseId);

        if (!caseExists)
            throw new Exception("Case not found.");

        var alreadyAccepted = await _questRepository.UserAlreadyAcceptedCaseAsync(
            request.UserId,
            request.CaseId);

        if (alreadyAccepted)
            throw new Exception("You have already accepted this case.");

        var quest = new Quest
        {
            UserId = request.UserId,
            MurderCaseId = request.CaseId,
            Status = QuestStatus.Accepted,
            Result = QuestResult.None,
            AcceptedAt = DateTime.UtcNow,
            ExpiresAt = DateTime.UtcNow.AddHours(24),
            Reminder20hSent = false,
            Reminder1hSent = false
        };

        var savedQuest = await _questRepository.AddAsync(quest);

        return new QuestAcceptedDto
        {
            Message = "Quest accepted.",
            QuestId = savedQuest.Id,
            MurderCaseId = savedQuest.MurderCaseId,
            Status = savedQuest.Status,
            Result = savedQuest.Result,
            AcceptedAt = savedQuest.AcceptedAt,
            ExpiresAt = savedQuest.ExpiresAt
        };
    }
}