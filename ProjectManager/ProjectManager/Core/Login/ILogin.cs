using DTO;

namespace ProjectManager.Core.Login
{
    interface ILogin
    {
        User Login(string username, string password);
    }
}
