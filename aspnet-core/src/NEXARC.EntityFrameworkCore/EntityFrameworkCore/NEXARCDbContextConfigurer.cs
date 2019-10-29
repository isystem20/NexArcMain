using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NEXARC.EntityFrameworkCore
{
    public static class NEXARCDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NEXARCDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
            //builder.UseSqlite(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NEXARCDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
            //builder.UseSqlite("Data Source=localdatabase.db");
        }
    }
}
