using MongoDB.Bson;

namespace CargoApp.Dal.Abstract;

public interface IGenericDal<T> where T : class
{
    Task CreateAsync(T entity);
    Task UpdateAsync(T entity);
    Task DeleteAsync(ObjectId id);
    Task<List<T>> GetListAsync();
    Task<T> GetByIdAsync(ObjectId id);
}