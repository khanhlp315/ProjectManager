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
        [Column(Name = "MemberID", DbType = "char(6)", Storage = "_MemID", CanBeNull = false)]
        int _MemID { get; set; }
        [Column(Name = "UserID", DbType = "char(6)", Storage = "_UserID", CanBeNull = false)]
        int _UserID { get; set; }
        [Column(Name = "Role", DbType = "char(1)", Storage = "_Role", CanBeNull = false)]
        int _Role { get; set; }

        public Member() { }
    }
}
