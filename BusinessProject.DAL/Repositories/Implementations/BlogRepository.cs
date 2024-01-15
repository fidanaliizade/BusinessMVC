using BusinessProject.Core.Common;
using BusinessProject.DAL.Context;
using BusinessProject.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DAL.Repositories.Implementations
{
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        public BlogRepository(AppDbContext db) : base(db)
        {
        }
    }
}
