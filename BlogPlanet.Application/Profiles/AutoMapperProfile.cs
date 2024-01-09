using AutoMapper;
using BlogPlanet.Application.Features.Blogs.Commands.AddBlog;
using BlogPlanet.Application.Features.Blogs.Commands.DeleteBlog;
using BlogPlanet.Application.Features.Blogs.Commands.UpdateBlog;
using BlogPlanet.Application.Features.Blogs.Queries.GetBlogDetails;
using BlogPlanet.Application.Features.Blogs.Queries.GetBlogList;
using BlogPlanet.Domain;

namespace BlogPlanet.Application.Profiles;
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        CreateMap<Blog, BlogsViewModel>().ReverseMap();
        CreateMap<Blog, SingleBlogViewModel>().ReverseMap();
        CreateMap<Blog, UpdateBlogCommand>().ReverseMap();
        CreateMap<Blog, AddBlogCommand>().ReverseMap();
        CreateMap<Blog, DeleteBlogCommand>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();

    }
}
