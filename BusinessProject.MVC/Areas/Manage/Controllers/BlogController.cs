using AutoMapper;
using BusinessProject.Business.Services.Interfaces;
using BusinessProject.Business.ViewModels.BlogVMs;
using BusinessProject.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BusinessProject.MVC.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BlogController : Controller
    {
        private readonly IBlogService _service;
        private readonly AppDbContext _db;
        private readonly IMapper _mapper;

        public BlogController(IBlogService service, AppDbContext db,IMapper mapper)
        {
            _service = service;
            _db = db;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var blogs = await _db.Blogs.Where(b => !b.IsDeleted).ToListAsync();
            return View(blogs);
        }

      
        [HttpGet]
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(BlogCreateVM vm)
        {
            await _service.Create(vm);
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var blog = await _service.GetById(id);
            var updated = _mapper.Map<BlogUpdateVM>(blog);
            return View(updated);
        }
        [HttpPost]
        public async Task<IActionResult> Update(BlogUpdateVM vm)
        {
            await _service.Update(vm);
            return RedirectToAction("Index");
        }
    }
}
