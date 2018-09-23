using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.ComponentModel;
namespace DTO
{
    [Table(Name = "User")]
    public class User: INotifyPropertyChanged
    {
        [Column(Name ="ID",DbType = "char(6)",Storage ="_id", CanBeNull = false, IsPrimaryKey = true)]
        private int _id { get; set; }

        [Column(Name = "UserName", DbType = "char(20)", Storage = "_username", CanBeNull = false)]
        private string _username { get; set; }

        [Column(Name = "Password", DbType = "char(20)", Storage = "_password", CanBeNull = false)]
        private string _password { get; set; }

        [Column(Name = "Permission", DbType = "char(1)", Storage = "_permission", CanBeNull = false)]
        private int _permission { get; set; }

        public User()
        {
            
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
