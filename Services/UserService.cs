using Minimal_API.Models;
using Minimal_API.Repositories;

namespace Minimal_API.Services
{
    public class UserService : IUserService
    {
        public User Get(UserLogin userLogin)
        {
            User user = UserRepository.Users.FirstOrDefault(o => o.UserName.Equals
            (userLogin.UserName, StringComparison.OrdinalIgnoreCase) && o.Password.Equals
            (userLogin.Password));
            return user;
        }
    }
}
