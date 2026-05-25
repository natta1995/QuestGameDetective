using AutoMapper;
using MediatR;
using QuestGameDetective.Application.Dtos.Case;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;


namespace QuestGameDetective.Application.Cases.Queries.GetAllCases;

public class GetAllCasesQueryHandler
    : IRequestHandler<GetAllCasesQuery, List<CaseReadDto>>
{
    private readonly IGenericRepository<MurderCase> _repository;
    private readonly IMapper _mapper;

    public GetAllCasesQueryHandler(
      IGenericRepository<MurderCase> repository,
      IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }
    public async Task<List<CaseReadDto>> Handle(
        GetAllCasesQuery request,
        CancellationToken cancellationToken)
    {
        var cases = await _repository.GetAllWithIncludesAsync("Suspects");

        return _mapper.Map<List<CaseReadDto>>(cases);
    }
}