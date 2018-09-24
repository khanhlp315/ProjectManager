using System.ComponentModel;
using System.Data.Linq;
using System.Data.Linq.Mapping;
namespace DTO
{
    [Table(Name = "User")]
    public class User : INotifyPropertyChanged
    {
        [Column(Name = "ID", DbType = "char(6)", Storage = "_ID", CanBeNull = false, IsPrimaryKey = true)]
        private int _ID { get; set; }

        public int Get_ID()
        {
            return _ID;
        }
        public void Set_ID(int id)
        {
            _ID = id;
        }
        [Column(Name = "UserName", DbType = "char(20)", Storage = "_UserName", CanBeNull = false)]
        private string _UserName { get; set; }

        public string Get_UserName()
        {
            return _UserName;
        }
        public void Set_UserName(string id)
        {
            _UserName = id;
        }

        [Column(Name = "Password", DbType = "char(20)", Storage = "_Password", CanBeNull = false)]
        private string _Password;

        public string Get_Password()
        {
            return _Password;
        }


        public void Set_Password(string value)
        {
            _Password = value;
        }

        

        [Column(Name = "Permission", DbType = "char(1)", Storage = "_Permission", CanBeNull = false)]
        private int _Permission;
        public int Get_Permission()
        {
            return _Permission;
        }

        public void Set_Permission(int value)
        {
            _Permission = value;
        }

        public User()
        {

        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
