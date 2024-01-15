using BusinessProject.Core.Common.Entity;
using BusinessProject.DAL.Context;
using BusinessProject.DAL.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject.DAL.Repositories.Implementations
{
 
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly AppDbContext _db;
        public DbSet<TEntity> Table { get;  set; }
        public  Repository( AppDbContext db)
        {
            _db = db;
            Table = _db.Set<TEntity>();
        }
        public async Task Create(TEntity entity)
        {
            await Table.AddAsync(entity);
        }

        public async Task Delete(int id)
        {
            var entity = await Table.FindAsync(id);
            entity.IsDeleted = true;
        }

        public  async Task<IQueryable<TEntity>> GetAllAsync()
        {
            IQueryable<TEntity> query = Table.Where(e=>!e.IsDeleted);
            return query;

        }

        public async Task<TEntity> GetById(int id)
        {
            return await Table.FindAsync(id);
        }

        public async Task SaveAllChanges()
        {
           await _db.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            Table.Update(entity);
        }
    }
}
