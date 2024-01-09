using BlogPlanet.Application.Contracts;

using BlogPlanet.Domain;
using Microsoft.EntityFrameworkCore;

namespace BlogPlanet.Presistence.Repositories;
internal class BlogRepository : BaseRepository<Blog>, IBlogRepository
{
    public BlogRepository(ApplicationDbContext context) : base(context)
    {

    }

    public async Task<Blog> GetBlogByIdAsync(int id, bool includeCategory)
    {
        Blog blog = new Blog();
        blog = includeCategory ? await _context.Blogs.Include(b => b.Category).FirstOrDefaultAsync(b => b.Id == id) : await _context.Blogs.FirstOrDefaultAsync(b => b.Id == id);
        return blog;
    }

    public async Task<IReadOnlyList<Blog>> GetBlogsAsync(bool includeCategory)
    {
        List<Blog> list = new List<Blog>();
        list = includeCategory ? await _context.Blogs.Include(b => b.Category).ToListAsync() : await _context.Blogs.ToListAsync();
        return list;
    }
}
