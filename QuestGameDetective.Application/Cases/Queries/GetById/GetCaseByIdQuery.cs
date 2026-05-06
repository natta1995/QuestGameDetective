using MediatR;
using QuestGameDetective.Application.Dtos.Case;

namespace QuestGameDetective.Application.Cases.Queries.GetCaseById;

public record GetCaseByIdQuery(Guid Id) : IRequest<CaseReadDto?>;