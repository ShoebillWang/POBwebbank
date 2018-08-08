using Abp.Application.Services.Dto;
using POBwebbank.Application.UserApp;
using POBwebbank.Web.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using POBwebbank.Models;

namespace POBwebbank.Controllers
{
    public class TransactOptionController : POBwebbankControllerBase
    {
        private readonly IUserAppService _userAppService;

        public TransactOptionController(IUserAppService userAppService) {
            _userAppService = userAppService;
        }

        // GET: TransactOption
        public ActionResult OftenUsedTransact(int id)
        {
            var users = _userAppService.GetMaintainUser(id);
            var model = new CommonTransactListModel {
                UserTransaction = users
            };
            return View(model);
        }
    }
}