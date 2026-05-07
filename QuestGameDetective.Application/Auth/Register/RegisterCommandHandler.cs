using MediatR;
using QuestGameDetective.Domain.Interfaces;

namespace QuestGameDetective.Application.Auth.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand>
{
    private readonly IAuthRepository _authRepository;

    public RegisterCommandHandler(IAuthRepository authRepository)
    {
        _authRepository = authRepository;
    }

    public async Task Handle(
        RegisterCommand request,
        CancellationToken cancellationToken)
    {
        await _authRepository.RegisterAsync(
            request.UserName,
            request.Email,
            request.Password);
    }
}