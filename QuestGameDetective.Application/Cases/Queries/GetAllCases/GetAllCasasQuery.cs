using MediatR;
using QuestGameDetective.Application.Dtos.Case;

namespace QuestGameDetective.Application.Cases.Queries.GetAllCases;

public record GetAllCasesQuery : IRequest<List<CaseReadDto>>;