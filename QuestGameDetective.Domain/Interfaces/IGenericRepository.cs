
namespace QuestGameDetective.Domain.Interfaces
{
   public interface IGenericRepository<T> where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<T?> GetByIdAsync(Guid id);
        Task AddAsync(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
        Task<List<T>> GetAllWithIncludesAsync(params string[] includes);

        Task<T?> GetByIdWithIncludesAsync(Guid id, params string[] includes);

    }
}
