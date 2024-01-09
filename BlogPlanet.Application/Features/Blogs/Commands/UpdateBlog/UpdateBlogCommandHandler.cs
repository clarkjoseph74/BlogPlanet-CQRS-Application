using AutoMapper;
using BlogPlanet.Application.Contracts;
using BlogPlanet.Domain;
using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.UpdateBlog;
public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, int>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public UpdateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
    {
        Blog blog = _mapper.Map<Blog>(request);
        await _blogRepository.UpdateAsync(blog);
        return blog.Id;
    }
}
