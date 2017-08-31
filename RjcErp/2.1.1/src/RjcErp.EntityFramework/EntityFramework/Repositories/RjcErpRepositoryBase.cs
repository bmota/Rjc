using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace RjcErp.EntityFramework.Repositories
{
    public abstract class RjcErpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<RjcErpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected RjcErpRepositoryBase(IDbContextProvider<RjcErpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class RjcErpRepositoryBase<TEntity> : RjcErpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected RjcErpRepositoryBase(IDbContextProvider<RjcErpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
