using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using NEXARC.Configuration;

namespace NEXARC.Web.Host.Startup
{
    [DependsOn(
       typeof(NEXARCWebCoreModule))]
    public class NEXARCWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public NEXARCWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NEXARCWebHostModule).GetAssembly());
        }
    }
}
