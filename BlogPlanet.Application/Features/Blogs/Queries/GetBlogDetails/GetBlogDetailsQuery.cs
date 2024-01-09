using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogDetails;
public class GetBlogDetailsQuery : IRequest<SingleBlogViewModel>
{
    public int BlogId { get; set; }
}
