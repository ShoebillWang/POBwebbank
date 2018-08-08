using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;
using POBwebbank.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POBwebbank.EntityFramework.Repository {
    public abstract class BaseRepository<TEntity, TPrimaryKey> : EfRepositoryBase<POBwebbankModel, TEntity, TPrimaryKey>
         where TEntity : class, IEntity<TPrimaryKey> {
        protected BaseRepository(IDbContextProvider<POBwebbankModel> dbContextProvider)
            : base(dbContextProvider) {

        }

        //add common methods for all repositories
    }

    public abstract class BaseRepository<TEntity> : BaseRepository<TEntity, Guid>
        where TEntity : class, IEntity<Guid> {
        protected BaseRepository(IDbContextProvider<POBwebbankModel> dbContextProvider)
            : base(dbContextProvider) {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
