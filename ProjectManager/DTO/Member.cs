using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using DTO;
namespace DTO
{
    
     public class Member
    {
        [Column(Name = "MemberID", DbType = "char(6)", Storage = "_permission", CanBeNull = false)]
        int memID;
        [Column(Name = "UserID", DbType = "char(6)", Storage = "_permission", CanBeNull = false)]
        int userID;
        [Column(Name = "Role", DbType = "char(1)", Storage = "_permission", CanBeNull = false)]
        int role;

        public Member() { }
    }
}
