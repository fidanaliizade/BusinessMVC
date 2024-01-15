using BusinessProject.Core.Common.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DAL.Repositories.Interfaces
{
    public interface IRepository <TEntity> where TEntity : BaseEntity , new()
    {
        public Task<IQueryable<TEntity>> GetAllAsync();
        public Task<TEntity> GetById(int id);
        public Task Create(TEntity entity);
        public void Update(TEntity entity);
        public Task Delete(int id);
        public Task SaveAllChanges();

    }
}
