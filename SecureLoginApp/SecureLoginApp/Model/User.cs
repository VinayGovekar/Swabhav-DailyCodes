
namespace SecureLoginApp.Model
{
    class User
    {
        private string _id, _password;
        private UserView _userView;
        public User(string id, string password,UserView user)
        {
            _id = id;
            _password = password;
            _userView = user;
        }
        public UserView UserDetails
        {
            get { return _userView; }
        }
        public string ID
        {
            get { return _id; }
        }
        public string Password { get { return _password; } }
    }
}
