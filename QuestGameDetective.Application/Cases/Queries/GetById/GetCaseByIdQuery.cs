using MediatR;
using QuestGameDetective.Application.Dtos.Cases;

namespace QuestGameDetective.Application.Cases.Queries.GetCaseById;

public record GetCaseByIdQuery(Guid Id) : IRequest<CaseReadDto?>;