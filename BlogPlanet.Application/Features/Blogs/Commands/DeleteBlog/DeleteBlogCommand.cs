using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.DeleteBlog;
public class DeleteBlogCommand : IRequest<int>
{
    public int Id { get; set; }
}
