using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.UpdateBlog;
public class UpdateBlogCommand : IRequest<int>
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }

    public int CategoryId { get; set; }
}
