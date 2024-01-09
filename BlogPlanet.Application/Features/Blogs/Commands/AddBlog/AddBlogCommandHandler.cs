using AutoMapper;
using BlogPlanet.Application.Contracts;
using BlogPlanet.Domain;
using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.AddBlog;
public class AddBlogCommandHandler : IRequestHandler<AddBlogCommand, int>
{

    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public AddBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(AddBlogCommand request, CancellationToken cancellationToken)
    {
        Blog blog = _mapper.Map<Blog>(request);
        var res = await _blogRepository.AddAsync(blog);
        return res.Id;
    }
}
