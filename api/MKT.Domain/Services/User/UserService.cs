using MKT.Domain.Interfaces.Repositories;
using MKT.Domain.Interfaces.Services;
using prmToolkit.NotificationPattern;

namespace MKT.Domain.Services.User
{
    public class UserService : Notifiable, IUserService
    {
        public IUserRepository UserRepository { get; set; }

        public UserService(IUserRepository userRepository)
        {
            UserRepository = userRepository;
        }

        public Task Login()
        {
            throw new NotImplementedException();
        }

        public Task Logout()
        {
            throw new NotImplementedException();
        }

        public Task Register()
        {
            throw new NotImplementedException();
        }

        public Task ChangePassword()
        {
            throw new NotImplementedException();
        }

        public Task RecoverPassword()
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
