using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace DTO
{
    [Table(Name = "User")]
    public class User : INotifyPropertyChanged
    {
        [Column(Name = "ID", DbType = "char(6)", CanBeNull = false, IsPrimaryKey = true)]
        //private string _id;
        public string id { get; set; }

        [Column(Name = "UserName", DbType = "char(20)", CanBeNull = false)]
        //private string _userName { get; set; }
        public string userName { get;set ; }

        [Column(Name = "Password", DbType = "char(20)", CanBeNull = false)]
        //private string _password;
        public string password { get; set; }

        [Column(Name = "Permission", DbType = "char(1)", CanBeNull = false)]
        //private int _permission;
        public int permission { get; set; }
        

        public User()
        {

        }
        public User(string userName, string password, int permission)
        {
            this.id = "0";
            this.userName = userName;
            this.password = password;
            this.permission = permission;
        }
        public User(string ID,string userName, string password, int permission)
        {
            this.id = ID;
            this.userName = userName;
            this.password = password;
            this.permission = permission;
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
