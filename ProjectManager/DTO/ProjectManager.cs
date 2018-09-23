using System;
using System.Collections.Generic;
//using System.Data.Entity;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    [Database]
    public class ProjectManager: DataContext
    {
       
        public ProjectManager(string connectionstring):base(connectionstring)
        {
           
        }
        public Table<User> User;
        public Table<Member> Member;
        
        
    }
}
