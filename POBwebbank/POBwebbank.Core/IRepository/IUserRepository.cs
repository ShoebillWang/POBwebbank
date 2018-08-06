using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Abp.Domain.Repositories;
using Abp.Domain.Entities;
using Abp.Authorization.Users;

namespace POBwebbank.Core.IRepository {
    public interface IUserRepository : IRepository<UserCommonTransaction, int> {

        List<UserCommonTransaction> GetAllUsers();
        void UpdateUser(UserCommonTransaction userEntity);
    }
}
