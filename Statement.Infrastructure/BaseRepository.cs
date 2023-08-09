using Microsoft.EntityFrameworkCore;
using Statements.Domain;

namespace Statements.Infrastructure
{
    public class BaseRepository<T> where T : class
    {
        protected readonly DbContext _context;
        protected readonly DbSet<T> _dbSet;
        
        public IQueryable<T> Table
        {
            get
            {
                return _dbSet;
            }
        }
        
        public BaseRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task SaveAsync(CancellationToken token)
        {
            await _context.SaveChangesAsync(token);
        }

        public async Task AddAsync (T entity, CancellationToken token)
        {
            await _dbSet.AddAsync(entity, token);

            await SaveAsync(token);
        }

        public async Task<T> GetAsync(string Id, CancellationToken token)
        {
            return await Table.FirstOrDefaultAsync(x => ((BaseEntity)(object)x).Id == Id, token);
        }

        public async Task<List<T>> GetAllAsync(CancellationToken token)
        {
            return await Table.ToListAsync(token);
        }

        public async Task UpdateAsync(T entity, CancellationToken token)
        {
            _dbSet.Update(entity);

            await SaveAsync(token);
        }

        public async Task RemoveAsync(string Id, CancellationToken token)
        {
            _dbSet.Remove(await GetAsync(Id, token));

            await SaveAsync(token);
        }
    }
}
