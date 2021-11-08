using System.Collections.Generic;

namespace SecureLoginApp.Model
{
    class SecurityService
    {
        private Dictionary<string, User> users = new Dictionary<string, User>();
        public SecurityService()
        {
            users.Add("vg101", new User("vg101", "Vinay", "Govekar", "vg@gmail.com", "vg@101"));
            users.Add("nd102",new User("nd102","Nelson","Dsouza","nd@gmail.com","nd@102"));
            users.Add("nk103",new User("nk103","Neeraj","Kasar","nk@gmail.com","nk@103"));
            users.Add("ak104",new User("ak104","Advait","Kunte","ak@gmail.com","ak@104"));
            users.Add("rs105",new User("rs105","Rajkumar","Singh","rs@gmail.com","rs@105"));
        }

        public User Login(string id,string password)
        {
            foreach (var user in users)
            {
                var LoginStatus = CheckUser(user.Value,id,password);
                if (LoginStatus != null) return LoginStatus;
            }
            throw new InvalidUserException();
        }

        private User CheckUser(User user, string id, string password)
        {
            if (user.ID == id && user.Password == password)
                return user;
            return null;
        }
    }
}
