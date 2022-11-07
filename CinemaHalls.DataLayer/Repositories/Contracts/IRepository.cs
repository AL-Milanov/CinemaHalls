namespace CinemaHalls.DataLayer.Repositories.Contracts
{
    public interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task<T> UpdateAsync(Guid entityId, T entity);
        void DeleteAsync(T entity);
        IQueryable<T> GetAllAsync();
        Task SaveChangesAsync();
    }
}
