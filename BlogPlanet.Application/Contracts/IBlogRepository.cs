using BlogPlanet.Domain;

namespace BlogPlanet.Application.Contracts;
public interface IBlogRepository : IBaseRepository<Blog>
{
    Task<IReadOnlyList<Blog>> GetBlogsAsync(bool includeCategory);
    Task<Blog> GetBlogByIdAsync(int id, bool includeCategory);
}
