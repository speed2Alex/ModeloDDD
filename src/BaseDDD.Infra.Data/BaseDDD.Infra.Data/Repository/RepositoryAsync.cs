using BaseDDD.Domain.Interfaces.Generico;
using BaseDDD.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BaseDDD.Infra.Data.Repository
{
    public abstract class RepositoryAsync<TEntity> : IRepositoryAsync<TEntity> where TEntity : class
    {
        protected readonly SqlContext Db;
        protected readonly DbSet<TEntity> DbSet;
        public RepositoryAsync(SqlContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<List<TEntity>> GetAll()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id) 
        {
            return await DbSet.FindAsync(id);
        }
        public async Task Add(TEntity obj)
        {
            DbSet.Add(obj);
            await SaveChanges();
        }

        public async Task Update(TEntity obj)
        {
            DbSet.Update(obj);
            await SaveChanges();
        }

        public async Task Remove(int id)
        {
            DbSet.Remove(await DbSet.FindAsync(id));
            await SaveChanges();
        }

        public async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
