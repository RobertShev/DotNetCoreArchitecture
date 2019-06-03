using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DotNetCoreArchitecture.Database
{
    public sealed class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<DatabaseContext>();

            builder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Database;Integrated Security=true;Connection Timeout=5;");

            return new DatabaseContext(builder.Options);
        }
    }
}
