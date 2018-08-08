using Abp.Application.Services;
using POBwebbank.Application.UserApp.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POBwebbank.Application.UserApp {
    public interface IUserAppService : IApplicationService {

        List<UserDto> GetMaintainUser(int UserId);
        void UpdateUser(UserDto maintainUser);
    }
}
