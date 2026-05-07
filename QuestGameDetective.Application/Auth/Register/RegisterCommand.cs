using MediatR;

namespace QuestGameDetective.Application.Auth.Commands.Register;

public record RegisterCommand(
    string UserName,
    string Email,
    string Password
) : IRequest;
