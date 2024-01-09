using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.AddBlog;
public class AddBlogCommand : IRequest<int>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    public int CategoryId { get; set; }
}
