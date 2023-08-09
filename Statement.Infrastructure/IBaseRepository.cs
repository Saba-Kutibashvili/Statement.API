namespace Statements.Infrastructure
{
    public interface IBaseRepository<T>
    {
        Task AddAsync(T entity, CancellationToken token);
        Task<T> GetAsync(string Id, CancellationToken token);
        Task<List<T>> GetAllAsync(CancellationToken token);
        Task UpdateAsync(T entity, CancellationToken token);
        Task RemoveAsync(string Id, CancellationToken token);
    }
}
