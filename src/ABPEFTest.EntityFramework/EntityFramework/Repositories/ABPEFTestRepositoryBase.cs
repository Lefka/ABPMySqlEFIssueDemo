using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ABPEFTest.EntityFramework.Repositories
{
    public abstract class ABPEFTestRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ABPEFTestDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPEFTestRepositoryBase(IDbContextProvider<ABPEFTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ABPEFTestRepositoryBase<TEntity> : ABPEFTestRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ABPEFTestRepositoryBase(IDbContextProvider<ABPEFTestDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
