using System.Collections.Generic;
using DTO;

namespace DAO
{
    public class UserDAL
    {

        public List<User> GetAllUsers()
        {
            List<User> users = new List<User>();

            return users;
        }

        public User GetUser(int id)
        {
            return new User();
        }

        public User GetUserByUserName(string username)
        {
            if(username == "admin")
            {
                return new User(-1, "admin", "admin", Permission.ADMIN);
            }
            return null;
        }

        public bool CheckIfUsernameExists(string username)
        {
            return true;
        }

        public void Insert(User user)
        {

        }

        public void Update(User user)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
