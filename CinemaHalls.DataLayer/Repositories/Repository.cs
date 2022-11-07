using CinemaHalls.DataLayer.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CinemaHalls.DataLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;

        public Repository(DbContext dbContext)
        {
            _context = dbContext;
            DbSet = _context.Set<T>();
        }

        private DbSet<T> DbSet { get; }

        public async Task AddAsync(T entity)
        {
            await DbSet.AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            DbSet.Remove(entity);
        }

        public IQueryable<T> GetAllAsync()
        {
            return DbSet;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(Guid entityId, T entity)
        {
            var entityToUpdate = await DbSet.FindAsync(entityId);

            if (entityToUpdate == null)
            {
                throw new Exception("Placeholder...");
            }

            return DbSet.Update(entity).Entity;
        }
    }
}
