namespace ICare.Application.Interfaces
{
    public interface IRepository<T, U> where T : class where U : class
    {
        Task<IEnumerable<U>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task<U> AddAsync(U entity);
        Task<U?> UpdateAsync(U entity, Guid id);
        Task<T?> DeleteAsync(Guid id);
    }
}
