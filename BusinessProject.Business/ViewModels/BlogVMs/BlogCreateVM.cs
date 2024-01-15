using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.ViewModels.BlogVMs
{
    public class BlogCreateVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImgUrl { get; set; }
    }
    public class BlogCreateVMValidation : AbstractValidator<BlogCreateVM>
    {
        public BlogCreateVMValidation()
        {
            RuleFor(x => x.Title).NotEmpty().MaximumLength(60);
            RuleFor(x => x.Description).NotEmpty().MaximumLength(120);
        }
    }
}
