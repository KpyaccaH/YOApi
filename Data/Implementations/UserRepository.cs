using YOApi.Data.Interfaces;
using YOApi.Models;

namespace YOApi.Data.Implementations
{
    class UserRepository : IUserRepository
    {
        public bool CreateUser(UserWithoutId user)
        {
            return true;
        }
        public bool Authorization(UserWithoutId user)
        {
            return true;
        }

        public bool CheckUserById(int id)
        {
            return true;
        }
    }
}