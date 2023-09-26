using Microsoft.EntityFrameworkCore;
using scrapapp.data.Abstract;

namespace scrapapp.data.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly DbContext context;
        public EfCoreGenericRepository(DbContext ctx) { context = ctx; }
        public void Create(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
        }
        public async Task CreateAsync(TEntity entity)
        {
            await context.Set<TEntity>().AddAsync(entity);
        }
        public virtual void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }
        public void Delete(TEntity entity)
        {
            context.Set<TEntity>().Remove(entity);
        }
    }
}