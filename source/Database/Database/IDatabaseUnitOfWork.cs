using System.Threading.Tasks;

namespace DotNetCoreArchitecture.Database
{
    public interface IDatabaseUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
