using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.ViewModels.BlogVMs
{
    public class BlogDetailVM
    {
        public string Title { get; set; }
        public int Id { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
    public class BlogDetailVMValidation : AbstractValidator<BlogDetailVM>
    {
        public BlogDetailVMValidation()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(60);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(120);
        }
    }

}
