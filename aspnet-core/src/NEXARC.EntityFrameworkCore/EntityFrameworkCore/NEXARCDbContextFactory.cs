using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NEXARC.Configuration;
using NEXARC.Web;

namespace NEXARC.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NEXARCDbContextFactory : IDesignTimeDbContextFactory<NEXARCDbContext>
    {
        public NEXARCDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NEXARCDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NEXARCDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NEXARCConsts.ConnectionStringName));

            return new NEXARCDbContext(builder.Options);
        }
    }
}
