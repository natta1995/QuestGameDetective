using MediatR;
using QuestGameDetective.Application.Dtos.Case;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Cases.Queries.GetCaseById;

public class GetCaseByIdQueryHandler
    : IRequestHandler<GetCaseByIdQuery, CaseReadDto?>
{
    private readonly IMurderCaseRepository _repository;

    public GetCaseByIdQueryHandler(IMurderCaseRepository repository)
    {
        _repository = repository;
    }

    public async Task<CaseReadDto?> Handle(
        GetCaseByIdQuery request,
        CancellationToken cancellationToken)
    {
        var murderCase = await _repository.GetByIdAsync(request.Id);

        if (murderCase == null)
            return null;

        return new CaseReadDto
        {
            Id = murderCase.Id,
            Title = murderCase.Title,
            ShortSummary = murderCase.ShortSummary,
            Victim = murderCase.Victim,
            Place = murderCase.Place,
            CauseOfDeath = murderCase.CauseOfDeath,
            Weapon = murderCase.Weapon,
            CrimeSceneDescription = murderCase.CrimeSceneDescription,
            Priority = murderCase.Priority,
            Suspects = murderCase.Suspects.Select(s => new SuspectDto
            {
                Name = s.Name,
                Statement = s.Statement
            }).ToList()
        };
    }
}