using BlogPlanet.Application.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BlogPlanet.Presistence.Repositories;
public class BaseRepository<T> : IBaseRepository<T> where T : class
{
    protected readonly ApplicationDbContext _context;

    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<T> AddAsync(T item)
    {
        await _context.Set<T>().AddAsync(item);
        await _context.SaveChangesAsync();
        return item;
    }

    public async Task DeleteAsync(T item)
    {
        _context.Set<T>().Remove(item);
        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync()
    {
        var result = await _context.Set<T>().ToListAsync();
        return result;
    }

    public async Task<T> GetByIdAsync(int id)
    {

        return await _context.Set<T>().FindAsync(id);
    }

    public async Task UpdateAsync(T item)
    {
        _context.Set<T>().Update(item);
        await _context.SaveChangesAsync();
    }
}
