using DTO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ProjectDAL
    {
        public ObservableCollection<Project> GetAllProjects()
        {
            List<Project> listProjects = new List<Project>();
            Table<Project> projects = DAL.DALConnection.Database.GetTable<Project>();
            ObservableCollection<Project> list = new ObservableCollection<Project>(projects);
            return list;
        }

        public Project GetUser(int id)
        {
            return new Project();
        }

        public Project GetUserByUserName(string username)
        {

            //User user = new User();
            //Table<Project> users = DAL.DALConnection.Database.GetTable<Project>();
            //var query =
            //from user in users
            //where user.userName == username
            //select user;
            return null;
            //return query.FirstOrDefault<Project>();
        }

        public bool CheckIfUsernameExists(string username)
        {
            return true;
        }

        public void Insert(Project user)
        {

        }

        public void Update(Project user)
        {

        }

        public void Delete(int id)
        {

        }
    }
}
