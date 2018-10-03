using System.Collections.Generic;
using DTO;
using System.Data.Linq;
using System.Linq;
using System;
using System.Collections.ObjectModel;

namespace DAL
{
    public class UserDAL
    {

        public ObservableCollection<User> GetAllUsers()
        {
            List<User> listUsers = new List<User>();
            Table<User> users = DAL.DALConnection.Database.GetTable<User>();
            if (users.Count<User>() > 0)
            {
                ObservableCollection<User> list = new ObservableCollection<User>(users);
                return list;
            }
                
            else
                return null;
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
