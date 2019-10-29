using Abp.EntityFrameworkCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Zero.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
//using Microsoft.Extensions.DependencyInjection;
//using Microsoft.EntityFrameworkCore.Migrations;
using NEXARC.EntityFrameworkCore.Seed;

namespace NEXARC.EntityFrameworkCore
{
    [DependsOn(
        typeof(NEXARCCoreModule),
        typeof(AbpZeroCoreEntityFrameworkCoreModule))]
    public class NEXARCEntityFrameworkModule : AbpModule
    {
        /* Used it tests to skip dbcontext registration, in order to use in-memory database of EF Core */
        public bool SkipDbContextRegistration { get; set; }

        public bool SkipDbSeed { get; set; }

        //private IApplicationBuilder _app;


        //public NEXARCEntityFrameworkModule(IApplicationBuilder app) {

        //    _app = app;

        //}


        public override void PreInitialize()
        {

            // add this line to disable transactions
            Configuration.UnitOfWork.IsTransactional = false;


            if (!SkipDbContextRegistration)
            {
                Configuration.Modules.AbpEfCore().AddDbContext<NEXARCDbContext>(options =>
                {
                    if (options.ExistingConnection != null)
                    {
                        NEXARCDbContextConfigurer.Configure(options.DbContextOptions, options.ExistingConnection);
                    }
                    else
                    {
                        NEXARCDbContextConfigurer.Configure(options.DbContextOptions, options.ConnectionString);
                    }

                });
            }

            //services.BuildServiceProvider().GetService<MyDatabaseContext>().Database.Migrate();

        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(NEXARCEntityFrameworkModule).GetAssembly());
        }

        public override void PostInitialize()
        {

            //using (var scope = _app.ApplicationServices
            //    .GetRequiredService<IServiceScopeFactory>()
            //    .CreateScope())
            //{
            //    scope.ServiceProvider.GetService<NEXARCDbContext>().Database.Migrate();
            //}


            if (!SkipDbSeed)
            {
                SeedHelper.SeedHostDb(IocManager);
            }
        }
    }
}
