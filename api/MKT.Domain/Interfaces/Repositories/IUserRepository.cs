using MKT.Domain.Entities;
using MKT.Domain.Interfaces.Repositories.Base;

namespace MKT.Domain.Interfaces.Repositories
{
    public interface IUserRepository : IRepositoryBase<User, Guid>
    {
    }
}
