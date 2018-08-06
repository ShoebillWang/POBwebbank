using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POBwebbank.Application.UserApp.Dto {

    public class UserDto : EntityDto {

        public Guid Id { get; set; }
        public int UserId { get; set; }
        public int TransactionId { get; set; }
        public int SetOrder { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
