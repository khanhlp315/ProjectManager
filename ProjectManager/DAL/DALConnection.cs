using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Linq;
using System.Data.Entity;
using DTO;

namespace DAL
{
    //[Table]
    public class DALConnection
    {
        public static ProjectManager Database { get ; set ; }         

        public DALConnection()
        { }
        public static bool CreateConnection(string connectionstring)
        {
            try
            {
                Database = new ProjectManager(connectionstring);
                if (!Database.DatabaseExists())
                {
                    User admin = new User("admin", "admin", 0);
                    Project project = new Project(000001, "abd@12", "myProject");
                    Project project2 = new Project(000002, "abd@12", "myProject");
                    Project project3 = new Project(000003, "abd@12", "myProject");
                    Project project4 = new Project(000004, "abd@12", "myProject");
                    Project project5 = new Project(000005, "abd@12", "myProject");
                    Project project6 = new Project(000006, "abd@12", "myProject");
                    Project project7 = new Project(000007, "abd@12", "myProject");
                    Project project8 = new Project(000008, "abd@12", "myProject");
                    Project project9 = new Project(000009, "abd@12", "myProject");
                    Project project10 = new Project(0000010, "abd@12", "myProject");
                    Project project11 = new Project(0000011, "abd@12", "myProject");
                    Project project12 = new Project(0000012, "abd@12", "myProject");
                    Database.CreateDatabase();
                    Database.User.InsertOnSubmit(admin);
                    Database.Project.InsertOnSubmit(project);
                    Database.Project.InsertOnSubmit(project2);
                    Database.Project.InsertOnSubmit(project3);
                    Database.Project.InsertOnSubmit(project4);
                    Database.Project.InsertOnSubmit(project5);
                    Database.Project.InsertOnSubmit(project6);
                    Database.Project.InsertOnSubmit(project7);
                    Database.Project.InsertOnSubmit(project8);
                    Database.Project.InsertOnSubmit(project9);
                    Database.Project.InsertOnSubmit(project10);
                    Database.Project.InsertOnSubmit(project11);
                    Database.Project.InsertOnSubmit(project12);
                    SummitChanges();
                    return true;    
                }
                else
                    return true;
                    
            }
            catch (Exception e) 
            {
                return false;
            }
        }
        public static void CloseConnection()
        {
            if (Database != null)
                Database.Dispose();
        }
        public void DiscardDeletes()
        {
            var changes = Database.GetChangeSet();
            foreach (var change in changes.Deletes)
            {
                Database.GetTable(change.GetType()).InsertOnSubmit(change);
            }

        }
        public void DiscardUpdate()
        {
            var changes = Database.GetChangeSet();
            var updatedTables = new List<ITable>();
            foreach (var change in changes.Updates)
            {
                var table = Database.GetTable(change.GetType());
                if (updatedTables.Contains(table))
                    continue;
                else
                {
                    updatedTables.Add(table);
                    Database.Refresh(RefreshMode.OverwriteCurrentValues, table);
                }
            }
        }
        public void DiscardInsert()
        {
            var changes = Database.GetChangeSet();
            foreach(var change in changes.Inserts)
            {
                Database.GetTable(change.GetType()).DeleteOnSubmit(change);
            }
        }
        public void DiscardEverything()
        {
            DiscardUpdate();
            DiscardInsert();
            DiscardUpdate();
            Database.SubmitChanges();
        }
        public bool IsModified()
        {
            var changes = Database.GetChangeSet();
            if (changes.Inserts.Count > 0 || changes.Updates.Count > 0 || changes.Deletes.Count > 0)
                return true;
            else
                return false;
        }
        public static void SummitChanges()
        {
            Database.SubmitChanges();
        }

    }
}
