using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using DTO;
using System.Data.Linq;

namespace DTO
{
    [Table(Name ="Member")]
     public class Member
    {
        [Column(Name = "MemberID", DbType = "char(6)", Storage = "_MemID", CanBeNull = false, IsPrimaryKey =true)]
        string _MemID { get; set; }

        [Column(Name ="UserID", DbType = "char(6)")]
        string _UserID { get; set; }
        private EntityRef<Project> _userID = new EntityRef<Project>();
        [Association(Storage ="_userID",IsForeignKey =true,ThisKey ="UserID")]
        public Project UserID { get => _userID.Entity; set => _userID.Entity = value; }
        
        [Column(Name = "Role", DbType = "char(1)", Storage = "_Role", CanBeNull = false)]
        int _Role { get; set; }
        

        public Member() { }
    }
}
