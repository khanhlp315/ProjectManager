using BUS.Exceptions;
using DAO;
using DTO;

namespace BUS
{
    public class LoginBUS
    {
        private UserDAL _userDAL = new UserDAL();

        //public User Login(string username, string password)
        //{
        //    //var user = _userDAL.GetUserByUserName(username);
        //    //if(user == null || user.Password != password)
        //    //{
        //    //    throw new CheckedException("Incorrect username or password!");
        //    //}

        //    //return user;
        //}
    }
}
