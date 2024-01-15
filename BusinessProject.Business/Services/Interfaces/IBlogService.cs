using BusinessProject.Business.ViewModels.BlogVMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.Services.Interfaces
{
    public interface IBlogService
    {
        public Task<IEnumerable<BlogListItemVM>> GetAll();
        public Task<BlogDetailVM> GetById(int id);
        public Task Create(BlogCreateVM vm);
        public Task Update(BlogUpdateVM vm);
        public Task Delete(int id);
    }
}
