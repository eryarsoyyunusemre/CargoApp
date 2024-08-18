using CargoApp.Dal.Abstract;
using CargoApp.Dal.Context;
using Microsoft.EntityFrameworkCore;
using MongoDB.Bson;

namespace CargoApp.Dal.Repository;

public class GenericRepository<T> : IGenericDal<T> where T :class
{
    private readonly CargoAppContext _context;

    public GenericRepository(CargoAppContext context)
    {
        _context = context;
    }

    public async Task CreateAsync(T entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(T entity)
    {
         _context.Update(entity);

         await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(ObjectId id)
    {
        var value = await GetByIdAsync(id);
        _context.Remove(value);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetListAsync()
    {
        return await _context.Set<T>().ToListAsync();
    }

    public async Task<T> GetByIdAsync(ObjectId id)
    {
        return await _context.Set<T>().FindAsync(id);
    }
}