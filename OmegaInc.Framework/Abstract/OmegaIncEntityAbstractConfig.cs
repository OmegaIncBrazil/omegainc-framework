using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OmegaInc.Framework.Abstract
{
    public abstract class OmegaIncEntityAbstractConfig<TEntity> : EntityTypeConfiguration<TEntity>
        where TEntity : class
    {
        public OmegaIncEntityAbstractConfig()
        {
            ConfigureTableName();
            ConfigureFieldsTable();
            ConfigurePK();
            ConfigureFK();
        }

        protected abstract void ConfigureFK();

        protected abstract void ConfigurePK();

        protected abstract void ConfigureFieldsTable();

        protected abstract void ConfigureTableName();
    }
}
