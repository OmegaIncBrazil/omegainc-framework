using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.Framework.Repository.Entity
{
    public abstract class GenericRepositoryEntity<TEntity, TKey> : IGenericRepository<TEntity, TKey>
       where TEntity : class
    {
        protected DbContext _context;

        public GenericRepositoryEntity(DbContext context)
        {
            _context = context;
        }
        public void Delete(TEntity entidade)
        {
            _context.Set<TEntity>().Attach(entidade);
            _context.Entry(entidade).State = EntityState.Deleted;
            _context.SaveChanges();
        }

        public void DeleteById(TKey id)
        {
            TEntity entidade = SelectById(id);
            Delete(entidade);
        }

        public void Edit(TEntity entidade)
        {
            _context.Set<TEntity>().Attach(entidade);
            _context.Entry(entidade).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Insert(TEntity entidade)
        {
            _context.Set<TEntity>().Add(entidade);
            _context.SaveChanges();
        }

        public virtual List<TEntity> Select()
        {
            return _context.Set<TEntity>().ToList();
        }

        public virtual TEntity SelectById(TKey id)
        {
            return _context.Set<TEntity>().Find(id);
        }
    }
}
