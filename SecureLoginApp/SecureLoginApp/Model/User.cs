
namespace SecureLoginApp.Model
{
    class User
    {
        private string _id, _firstName, _lastName, _email, _password;
        public User(string id,string firstname, string lastname, string email, string password)
        {
            _id = id;
            _firstName = firstname;
            _lastName = lastname;
            _email = email;
            _password = password;
        }
        public string ID
        {
            get { return _id; }
        }
        public string FirstName
        {
            get { return _firstName; }
        }
        public string LastName
        {
            get { return _lastName; }
        }
        public string Email { get { return _email; } }
        public string Password { get { return _password; } }
    }
}
