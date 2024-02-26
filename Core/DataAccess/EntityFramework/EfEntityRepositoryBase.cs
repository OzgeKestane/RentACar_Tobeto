using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TEntityId, TContext> : IEntityRepository<TEntity, TEntityId>
        where TEntity : Entity<TEntityId>
        where TContext : DbContext
    {

        protected readonly TContext Context;

        public EfEntityRepositoryBase(TContext context)
        {
            Context = context;
        }

        public TEntity Add(TEntity entity)
        {
            entity.CreatedAt = DateTime.UtcNow;
            Context.Add(entity);
            Context.SaveChanges();
            return entity;
            //using (TContext context = new TContext())
            //{
            //    entity.CreatedAt = DateTime.UtcNow;
            //    var addedEntity = context.Entry(entity);
            //    addedEntity.State = EntityState.Added;
            //    context.SaveChanges();
            //    return entity;
            //}
        }

        public TEntity Delete(TEntity entity, bool isSoftDelete = true)
        {
            entity.DeletedAt = DateTime.UtcNow;
            //Context.Entry(entity).State = EntityState.Modified;

            if (!isSoftDelete)
            {
                Context.Remove(entity);
            }
            Context.SaveChanges();
            return entity;
        }

        public TEntity? Get(Func<TEntity, bool> predicate)
        {

            return Context.Set<TEntity>().FirstOrDefault(predicate);

        }

        public IList<TEntity> GetList(Func<TEntity, bool>? predicate = null)
        {
            IQueryable<TEntity> entities = Context.Set<TEntity>();
            if (predicate is not null)
                entities = entities.Where(predicate).AsQueryable();

            return entities.ToList();
        }

        public TEntity Update(TEntity entity)
        {
            entity.UpdatedAt = DateTime.UtcNow;
            Context.Update(entity);
            Context.SaveChanges();
            return entity;
        }
    }
}
