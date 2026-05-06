using MediatR;
using QuestGameDetective.Application.Dtos.User;

namespace QuestGameDetective.Application.Users.Queries.GetAllUsers;

public record GetAllUsersQuery : IRequest<List<UserReadDto>>;