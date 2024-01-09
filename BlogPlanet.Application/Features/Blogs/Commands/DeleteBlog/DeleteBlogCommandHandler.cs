using AutoMapper;
using BlogPlanet.Application.Contracts;
using BlogPlanet.Domain;
using MediatR;

namespace BlogPlanet.Application.Features.Blogs.Commands.DeleteBlog;
public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand, int>
{
    private readonly IBlogRepository _blogRepository;
    private readonly IMapper _mapper;

    public DeleteBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
    {
        _blogRepository = blogRepository;
        _mapper = mapper;
    }

    public async Task<int> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
    {
        Blog blog = await _blogRepository.GetBlogByIdAsync(request.Id, false);
        if (blog == null)
        {
            return 0;
        }
        await _blogRepository.DeleteAsync(blog);
        return blog.Id;
    }
}
