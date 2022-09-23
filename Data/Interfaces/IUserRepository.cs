using YOApi.Models;

namespace YOApi.Data.Interfaces
{
    public interface IUserRepository
    {
        public bool CreateUser(UserWithoutId user);
        public bool Authorization(UserWithoutId user);
        public bool CheckUserById(int id);
    }
}