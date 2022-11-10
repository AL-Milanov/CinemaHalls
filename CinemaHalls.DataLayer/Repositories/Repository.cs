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

        public async Task<T> AddAsync(T entity)
        {
            var addedEntity = await DbSet.AddAsync(entity);

            return addedEntity.Entity;
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

        public T Update(T entity)
        {
            return DbSet.Update(entity).Entity;
        }
    }
}
