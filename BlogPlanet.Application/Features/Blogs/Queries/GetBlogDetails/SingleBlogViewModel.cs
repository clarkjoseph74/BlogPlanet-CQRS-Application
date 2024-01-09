using BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;

namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogDetails;
public class SingleBlogViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public CategoryDto Category { get; set; }
}
