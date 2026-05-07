using QuestGameDetective.Domain.Entities;

namespace QuestGameDetective.Domain.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(ApplicationUser user);
    }
}