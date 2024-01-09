using AutoMapper;
using BlogPlanet.Application.Contracts;
using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;
public class GetBlogListQueryHandler : IRequestHandler<GetBlogListQuery, List<BlogsViewModel>>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;


    public GetBlogListQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }


    public async Task<List<BlogsViewModel>> Handle(GetBlogListQuery request, CancellationToken cancellationToken)
    {
        var allBlogs = await _blogRepository.GetBlogsAsync(true);
        var result = _mapper.Map<List<BlogsViewModel>>(allBlogs);
        return result;
    }
}
