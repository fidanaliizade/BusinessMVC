using AutoMapper;
using BusinessProject.Business.Exceptions;
using BusinessProject.Business.Exceptions.Common;
using BusinessProject.Business.Services.Interfaces;
using BusinessProject.Business.ViewModels.BlogVMs;
using BusinessProject.Core.Common;
using BusinessProject.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.Business.Services.Implementations
{
    public class BlogService : IBlogService
    {
        private readonly IBlogRepository _repository;
        private readonly IMapper _mapper;

        public BlogService(IBlogRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task Create(BlogCreateVM vm)
        {
            var blog = _mapper.Map<BlogCreateVM, Blog>(vm);
            await _repository.Create(blog);
            await _repository.SaveAllChanges();
        }

        public async Task Delete(int id)
        {
            if (id <= 0) throw new NegativeIdException();
            await _repository.Delete(id);
            await _repository.SaveAllChanges();
        }

        public async Task<IEnumerable<BlogListItemVM>> GetAll()
        {
            var blogs = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<BlogListItemVM>>(blogs);
        }

        public async Task<BlogDetailVM> GetById(int id)
        {
           if(id<=0) throw new NegativeIdException();
           var blog = await _repository.GetById(id);
            return _mapper.Map<BlogDetailVM>(blog);
        }

        public async Task Update(BlogUpdateVM vm)
        {
            if(vm.Id<=0) throw new NegativeIdException();
            if (await _repository.GetById(vm.Id) == null) throw new BlogNullException();
            var blog = await _repository.GetById(vm.Id);
            _repository.Update(_mapper.Map(vm, blog));
            //_mapper.Map<Blog>(vm);
            //_repository.Update(blog);
            await _repository.SaveAllChanges();
        }
    }
}
