using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.DAL.DataContext;

namespace VMS.DAL.Repositories
{
  public abstract  class RepositoryBase<TEntity> where TEntity:class
    {
        internal DataContext.VMSDataContext context;
        internal DbSet<TEntity> dbSet;

        public RepositoryBase(VMSDataContext ctx)
        {
            this.context = ctx;
            this.dbSet= context.Set<TEntity>();
        }

        public virtual TEntity GetByID(object ID)
        {
            return dbSet.Find(ID);
        }

        public virtual void Insert(TEntity entity)
        {
            dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            dbSet.Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Delete(TEntity entity)
        {
            if (context.Entry(entity).State == EntityState.Detached)
                dbSet.Attach(entity);
            dbSet.Remove(entity);
        }

        public virtual void Delete(object ID)
        {
            TEntity ent = dbSet.Find(ID);
            Delete(ent);
        }
        public virtual IQueryable<TEntity> GetAll()
        {
            return dbSet;
        }

        public virtual void Committ()
        {
            context.SaveChanges();
        }
    }
}
