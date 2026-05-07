namespace QuestGameDetective.Domain.Interfaces
{
    public interface IAuthRepository
    {
        Task RegisterAsync(string userName, string email, string password);

        Task<string> LoginAsync(string email, string password);
    }
}
