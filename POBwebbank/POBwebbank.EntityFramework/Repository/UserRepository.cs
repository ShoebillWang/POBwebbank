using System.Collections.Generic;
using System.Linq;
using Abp.EntityFramework;
using POBwebbank.Core;
using POBwebbank.Core.IRepository;

namespace POBwebbank.EntityFramework.Repository {
    public class UserRepository : BaseRepository<UserCommonTransaction, int>, IUserRepository {

        public UserRepository(IDbContextProvider<POBwebbankModel> dbContextProvider) : base(dbContextProvider) {
        }

        public List<UserCommonTransaction> GetAllUsers() {
            return GetAll().ToList();
        }

        public void UpdateUser(UserCommonTransaction userEntity) {
            Update(userEntity);
        }
    }
}
