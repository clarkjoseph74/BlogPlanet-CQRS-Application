namespace BlogPlanet.Application.Contracts;
public interface IBaseRepository<T> where T : class
{
    Task<T> GetByIdAsync(int id);
    Task<List<T>> GetAllAsync();
    Task<T> AddAsync(T item);
    Task UpdateAsync(T item);
    Task DeleteAsync(T item);
}
