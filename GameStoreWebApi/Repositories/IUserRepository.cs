using GameStoreWebApi.Models;

namespace GameStoreWebApi.Repositories
{
    public interface IUserRepository
    {
        // methods like Register, Login, and UserExists
        Task<User> Register(User user, string password);
        Task<User> Login(string username, string password);
        Task<bool> UserExists(string username);

    }
}
