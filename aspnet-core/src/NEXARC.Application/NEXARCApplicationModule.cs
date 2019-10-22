using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NEXARC.Authorization;

namespace NEXARC
{
    [DependsOn(
        typeof(NEXARCCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class NEXARCApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<NEXARCAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(NEXARCApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
