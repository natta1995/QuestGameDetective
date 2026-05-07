using MediatR;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Auth.Commands.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
{
    private readonly IAuthRepository _authRepository;

    public LoginCommandHandler(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task<string> Handle(
        LoginCommand request,
        CancellationToken cancellationToken)
    {
        return await _authRepository.LoginAsync(
            request.Email,
            request.Password);
    }
}