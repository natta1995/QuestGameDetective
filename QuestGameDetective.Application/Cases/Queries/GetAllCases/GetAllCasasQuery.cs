using MediatR;
using QuestGameDetective.Application.Dtos.Cases;

namespace QuestGameDetective.Application.Cases.Queries.GetAllCases;

public record GetAllCasesQuery : IRequest<List<CaseReadDto>>;