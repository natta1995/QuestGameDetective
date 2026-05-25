using MediatR;
using AutoMapper;
using QuestGameDetective.Application.Dtos.Case;
using QuestGameDetective.Domain.Entities;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Cases.Queries.GetCaseById;

public class GetCaseByIdQueryHandler
    : IRequestHandler<GetCaseByIdQuery, CaseReadDto?>
{
    private readonly IGenericRepository<MurderCase> _repository;
    private readonly IMapper _mapper;

    public GetCaseByIdQueryHandler(
      IGenericRepository<MurderCase> repository,
      IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<CaseReadDto?> Handle(
        GetCaseByIdQuery request,
        CancellationToken cancellationToken)
    {
        var murderCase = await _repository.GetByIdWithIncludesAsync(request.Id, "Suspects");

        if (murderCase == null)
            return null;

        return _mapper.Map<CaseReadDto>(murderCase);
    }
}