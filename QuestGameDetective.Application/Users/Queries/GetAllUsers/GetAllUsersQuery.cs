using MediatR;
using QuestGameDetective.Application.Dtos.Users;

namespace QuestGameDetective.Application.Users.Queries.GetAllUsers;

public record GetAllUsersQuery : IRequest<List<UserReadDto>>;