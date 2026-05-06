using MediatR;
using QuestGameDetective.Application.Dtos.Users;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Users.Queries.GetAllUsers;

public class GetAllUsersQueryHandler
    : IRequestHandler<GetAllUsersQuery, List<UserReadDto>>
{
    private readonly IUserRepository _userRepository;

    public GetAllUsersQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<List<UserReadDto>> Handle(
        GetAllUsersQuery request,
        CancellationToken cancellationToken)
    {
        var users = await _userRepository.GetAllAsync();

        return users
            .OrderBy(u => u.UserName)
            .Select(u => new UserReadDto
            {
                Id = u.Id,
                UserName = u.UserName ?? "",
                Email = u.Email ?? ""
            })
            .ToList();
    }
}