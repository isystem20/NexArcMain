using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace NEXARC.Controllers
{
    public abstract class NEXARCControllerBase: AbpController
    {
        protected NEXARCControllerBase()
        {
            LocalizationSourceName = NEXARCConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
