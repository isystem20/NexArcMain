using Abp.MultiTenancy;
using NEXARC.Authorization.Users;

namespace NEXARC.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
