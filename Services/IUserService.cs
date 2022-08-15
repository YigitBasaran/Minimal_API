using Minimal_API.Models;

namespace Minimal_API.Services
{
    public interface IUserService
    {
        public User Get(UserLogin userLogin);
    }
}
