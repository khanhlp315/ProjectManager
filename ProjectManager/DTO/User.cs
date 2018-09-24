namespace DTO
{
    public class User
    {
        private int _id;
        private string _username;
        private string _password;
        private Permission _permission;

        public User(int id = -1, string username = "", string password = "", Permission permission = Permission.MEMBER)
        {
            _id = id;
            _username = username;
            _password = password;
            _permission = Permission.MEMBER;
        }

        public int ID
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                _username = value;
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public Permission Permission
        {
            get
            {
                return _permission;
            }
            set
            {
                _permission = value;
            }
        }
    }
}
