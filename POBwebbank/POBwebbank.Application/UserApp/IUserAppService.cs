using Abp.Application.Services;
using POBwebbank.Application.UserApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POBwebbank.Application.UserApp {
    public interface IUserAppService : IApplicationService {

        UserDto GetMaintainUser(int user_id);
        void UpdateUser(UserDto maintainUser);
    }
}
