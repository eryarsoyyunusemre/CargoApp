using CargoApp.Bll.Abstract;
using CargoApp.Dal.Abstract;
using MongoDB.Bson;

namespace CargoApp.Bll.Concrete;

public class GenericManager<T> : IGenericService<T> where T :class
{
    private readonly IGenericDal<T> _genericDal;

    public GenericManager(IGenericDal<T> genericDal)
    {
        _genericDal = genericDal;
    }
    

    public async Task TCreateAsync(T entity)
    {
        await _genericDal.CreateAsync(entity);
    }

    public async Task TUpdateAsync(T entity)
    {
        await _genericDal.UpdateAsync(entity);
    }

    public async Task TDeleteAsync(ObjectId id)
    {
        await _genericDal.DeleteAsync(id);
    }

    public async Task<List<T>> TGetListAsync()
    {
        return await _genericDal.GetListAsync();
    }

    public async Task<T> TGetByIdAsync(ObjectId id)
    {
        return await _genericDal.GetByIdAsync(id);
    }
}