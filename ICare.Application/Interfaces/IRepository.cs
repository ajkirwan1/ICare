namespace ICare.Application.Interfaces
{
    public interface IRepository<T, U> where T : class where U : class
    {
        Task<IEnumerable<U>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<T> AddAsync(T entity);
        Task<T?> UpdateAsync(T entity);
        Task<T?> DeleteAsync(Guid id);
    }
}
