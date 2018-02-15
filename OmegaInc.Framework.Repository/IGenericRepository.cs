using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.Framework.Repository
{
    public interface IGenericRepository<TEntity, TKey>
        where TEntity : class
    {
        List<TEntity> Select();
        TEntity SelectById(TKey id);
        void Insert(TEntity entidade);
        void Edit(TEntity entidade);
        void Delete(TEntity entidade);
        void DeleteById(TKey id);
    }
}
