using System.Linq;
using POBwebbank.Core.IRepository;
using POBwebbank.Application.UserApp.Dto;
using POBwebbank.Core;

namespace POBwebbank.Application.UserApp {

    public class UserAppService : IUserAppService {
        private readonly IUserRepository _userRepository;

        public UserAppService(IUserRepository userRepository) {
            _userRepository = userRepository;
        }

        //public GetUserOutput GetAllUsers() {

        //    GetUserOutput users = new GetUserOutput();
        //    users.UserList = _userRepository.GetAllUsers().
        //       Select(u => new UserDto {
        //           user_Id = u.Id,
        //           user_name = u.user_name,
        //           dept_Id = u.dept_id.Value
        //       }).ToList();

        //    return users;
        //}

        public UserDto GetMaintainUser(int user_id) {
            UserDto MaintainUser = new UserDto();

            MaintainUser = _userRepository.GetAllUsers().
                Select(u => new UserDto {
                    Id = u.Id,
                    UserId = u.UserId,
                    TransactionId = u.TransactionId,
                    SetOrder = u.SetOrder,
                    UpdateTime = u.UpdateTime

                }).SingleOrDefault();

            return MaintainUser;
        }

        public void UpdateUser(UserDto maintainUser) {
            UserCommonTransaction userEntity = new UserCommonTransaction() {
                Id = maintainUser.Id,
                UserId = maintainUser.UserId,
                TransactionId = maintainUser.TransactionId,
                SetOrder = maintainUser.SetOrder,
                UpdateTime = maintainUser.UpdateTime
            };

            _userRepository.UpdateUser(userEntity);
        }
    }
}
