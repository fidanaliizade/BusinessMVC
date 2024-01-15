using AutoMapper;
using BusinessProject.Business.ViewModels.BlogVMs;
using BusinessProject.Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.Profiles
{
    public class BlogMapper : Profile
    {
        public BlogMapper()
        {
            CreateMap<Blog, BlogCreateVM>();
            CreateMap<Blog, BlogCreateVM>().ReverseMap();
            CreateMap<Blog,BlogUpdateVM>();
            CreateMap<Blog, BlogUpdateVM>().ReverseMap();
            CreateMap<Blog, BlogListItemVM>();
            CreateMap<Blog, BlogListItemVM>().ReverseMap();
            CreateMap<BlogUpdateVM, BlogDetailVM>();
            CreateMap<BlogUpdateVM, BlogDetailVM>().ReverseMap();
        }
    }
}
