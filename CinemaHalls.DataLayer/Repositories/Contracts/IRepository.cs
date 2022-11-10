namespace CinemaHalls.DataLayer.Repositories.Contracts
{
    public interface IRepository<T>
    {
        Task<T> AddAsync(T entity);
        T Update(T entity);
        void DeleteAsync(T entity);
        IQueryable<T> GetAllAsync();
        Task SaveChangesAsync();
    }
}
