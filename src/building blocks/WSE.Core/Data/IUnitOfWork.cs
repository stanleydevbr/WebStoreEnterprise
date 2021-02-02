using System.Threading.Tasks;

namespace WSE.Core.Data
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
