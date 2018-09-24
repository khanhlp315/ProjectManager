using System.Collections.Generic;
using DTO;
using System.Data.Linq;
using System.Linq;
using System;

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

            //User user = new User();
            Table<User> users = DAL.DALConnection.Database.GetTable<User>();
            var query =
            from user in users
            where user.userName == username
            select user;

            return query.FirstOrDefault<User>();
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
