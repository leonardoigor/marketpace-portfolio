using MKT.Domain.Services.Base;

namespace MKT.Domain.Interfaces.Services
{
    public interface IUserService : IServiceBase
    {

        public Task Login();
        public Task Logout();
        public Task Register();
        public Task ChangePassword();
        public Task RecoverPassword();
        public Task Remove(Guid id);
    }
}