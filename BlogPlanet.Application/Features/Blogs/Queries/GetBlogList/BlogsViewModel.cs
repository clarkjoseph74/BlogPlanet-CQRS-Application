namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;
public class BlogsViewModel
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ImageUrl { get; set; }
    public CategoryDto Category { get; set; }
}
