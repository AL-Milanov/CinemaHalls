using CinemaHalls.DataLayer.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace CinemaHalls.DataLayer.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(T entity)
        {
            await DbSet<T>().AddAsync(entity);
        }

        public void DeleteAsync(T entity)
        {
            DbSet<T>().Remove(entity);
        }

        public IQueryable<T> GetAllAsync()
        {
            return DbSet<T>();
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<T> UpdateAsync(Guid entityId, T entity)
        {
            var entityToUpdate = await DbSet<T>().FindAsync(entityId);

            if (entityToUpdate == null)
            {
                throw new Exception("Placeholder...");
            }

            return DbSet<T>().Update(entity).Entity;
        }

        private DbSet<T> DbSet<T>() where T : class
        {
            return _dbContext.Set<T>();
        }
    }
}
