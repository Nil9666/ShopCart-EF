using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ShopCart.EntityFramework.Repositories
{
    public abstract class ShopCartRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ShopCartDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ShopCartRepositoryBase(IDbContextProvider<ShopCartDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ShopCartRepositoryBase<TEntity> : ShopCartRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ShopCartRepositoryBase(IDbContextProvider<ShopCartDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
