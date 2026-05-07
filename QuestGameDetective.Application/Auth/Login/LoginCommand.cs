using MediatR;

namespace QuestGameDetective.Application.Auth.Commands.Login;

public record LoginCommand(
    string Email,
    string Password
) : IRequest<string>;