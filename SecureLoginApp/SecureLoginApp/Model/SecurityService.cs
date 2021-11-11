using System.Collections.Generic;

namespace SecureLoginApp.Model
{
    class SecurityService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        public SecurityService()
        {
            users.Add("vg101", new User("vg101","vg@101",new UserView("vg@gmail.com","Vinay","Govekar")));
            users.Add("nd102", new User("nd102", "nd@102", new UserView("nd@gmail.com", "Nelson", "Dsouza")));
            users.Add("nk103", new User("nk103", "nk@103", new UserView("nk@gmail.com", "Neeraj", "Kasar")));
            users.Add("ak104", new User("ak104", "ak@104", new UserView("ak@gmail.com", "Advait", "Kunte")));
            users.Add("rs105", new User("rs105", "rs@105", new UserView("rs@gmail.com", "Raj", "Singh")));
        }

        public UserView Login(string id,string password)
        {
            foreach (var user in users)
            {
                var LoginStatus = CheckUser(user.Value,id,password);
                if (LoginStatus != null) return LoginStatus;
            }
            throw new InvalidUserException();
        }

        private UserView CheckUser(User user, string id, string password)
        {
            if (user.ID == id && user.Password == password)
                return user.UserDetails;
            return null;
        }
    }
}
