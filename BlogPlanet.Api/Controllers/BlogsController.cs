using BlogPlanet.Application.Features.Blogs.Commands.AddBlog;
using BlogPlanet.Application.Features.Blogs.Commands.DeleteBlog;
using BlogPlanet.Application.Features.Blogs.Commands.UpdateBlog;
using BlogPlanet.Application.Features.Blogs.Queries.GetBlogDetails;
using BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlanet.Api.Controllers;
[Route("api/[controller]")]
[ApiController]
public class BlogsController : ControllerBase
{
    private readonly IMediator _mediator;

    public BlogsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("all", Name = "GetAllBlogs")]
    public async Task<IActionResult> GetAllBlogs()
    {
        return Ok(await _mediator.Send(new GetBlogListQuery()));
    }
    [HttpGet("{id}", Name = "GetBlogById")]
    public async Task<IActionResult> GetBlogById(int id)
    {
        var blog = await _mediator.Send(new GetBlogDetailsQuery() { BlogId = id });
        return Ok(blog);
    }
    [HttpPost(Name = "AddNewBlog")]
    public async Task<IActionResult> AddNewBlog([FromBody] AddBlogCommand addBlog)
    {
        int id = await _mediator.Send(addBlog);

        return Ok(id);
    }
    [HttpPut(Name = "UpdateBlog")]
    public async Task<IActionResult> UpdateBlog([FromBody] UpdateBlogCommand updateBlog)
    {
        var id = await _mediator.Send(updateBlog);
        return Ok(id);
    }
    [HttpDelete(Name = "DeleteBlog")]
    public async Task<IActionResult> DeleteBlog([FromBody] DeleteBlogCommand deleteBlog)
    {
        var id = await _mediator.Send(deleteBlog);
        return Ok(id);
    }

}
