using DotNetCore.EntityFrameworkCore;
using DotNetCoreArchitecture.Domain;

namespace DotNetCoreArchitecture.Database
{
    public sealed class UserLogRepository : EntityFrameworkCoreRelationalRepository<UserLogEntity>, IUserLogRepository
    {
        public UserLogRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
