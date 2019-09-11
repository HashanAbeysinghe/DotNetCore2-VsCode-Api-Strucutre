using System.Threading;
using System.Threading.Tasks;

namespace ALMaster.Domain
{
    public interface IUnitOfWork
    {
        int SaveChanges();

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
