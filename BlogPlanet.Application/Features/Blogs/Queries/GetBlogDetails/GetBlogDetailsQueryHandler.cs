using AutoMapper;
using BlogPlanet.Application.Contracts;
using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Queries.GetBlogDetails;
public class GetBlogDetailsQueryHandler : IRequestHandler<GetBlogDetailsQuery, SingleBlogViewModel>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public GetBlogDetailsQueryHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<SingleBlogViewModel> Handle(GetBlogDetailsQuery request, CancellationToken cancellationToken)
    {
        var blog = await _blogRepository.GetBlogByIdAsync(request.BlogId, true);
        var result = _mapper.Map<SingleBlogViewModel>(blog);
        return result;
    }
}
