using Abp.IdentityFramework;
using Abp.UI;
using Abp.Web.Mvc.Controllers;
using Microsoft.AspNet.Identity;

namespace POBwebbank.Web.Controllers {
    /// <summary>
    /// Derive all Controllers from this class.
    /// </summary>
    public abstract class POBwebbankControllerBase : AbpController {
        protected POBwebbankControllerBase() {
            LocalizationSourceName = POBwebbankConsts.LocalizationSourceName;
        }

        protected virtual void CheckModelState() {
            if (!ModelState.IsValid) {
                throw new UserFriendlyException(L("FormIsNotValidMessage"));
            }
        }

        protected void CheckErrors(IdentityResult identityResult) {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}