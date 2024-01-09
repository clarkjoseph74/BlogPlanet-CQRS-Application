using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;
public class GetBlogListQuery : IRequest<List<BlogsViewModel>>
{
}
