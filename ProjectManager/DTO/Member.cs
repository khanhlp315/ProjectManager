using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using DTO;
namespace DTO
{
    [Table(Name ="Member")]
     public class Member
    {
        [Column(Name = "MemberID", DbType = "char(6)", Storage = "_memID", CanBeNull = false)]
        int _memID;
        [Column(Name = "UserID", DbType = "char(6)", Storage = "_userID", CanBeNull = false)]
        int _userID;
        [Column(Name = "Role", DbType = "char(1)", Storage = "_role", CanBeNull = false)]
        int _role;

        public Member() { }
    }
}
