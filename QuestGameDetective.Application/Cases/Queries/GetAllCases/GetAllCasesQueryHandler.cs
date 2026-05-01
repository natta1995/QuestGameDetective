
using MediatR;
using QuestGameDetective.Application.Dtos.Cases;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Cases.Queries.GetAllCases;

public class GetAllCasesQueryHandler
    : IRequestHandler<GetAllCasesQuery, List<CaseReadDto>>
{
    private readonly IMurderCaseRepository _repository;

    public GetAllCasesQueryHandler(IMurderCaseRepository repository)
    {
        _repository = repository;
    }

    public async Task<List<CaseReadDto>> Handle(
        GetAllCasesQuery request,
        CancellationToken cancellationToken)
    {
        var cases = await _repository.GetAllAsync();

        return cases.Select(c => new CaseReadDto
        {
            Id = c.Id,
            Title = c.Title,
            ShortSummary = c.ShortSummary,
            Victim = c.Victim,
            Place = c.Place,
            CauseOfDeath = c.CauseOfDeath,
            Weapon = c.Weapon,
            CrimeSceneDescription = c.CrimeSceneDescription,
            Priority = c.Priority,
            Suspects = c.Suspects.Select(s => new SuspectDto
            {
                Name = s.Name,
                Statement = s.Statement
            }).ToList()
        }).ToList();
    }
}