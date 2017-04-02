using System.Collections.Generic;

namespace Permissions
{
    class User
    {
        public string Password { get; set; } = "0000";
        public string Username { get; set; }

        public static Dictionary<string, User> Instances = 
            new Dictionary<string, User>();

        // Привелегии:
        public bool CanRead { get; set; } = true;
        public bool CanChange { get; set; } = false;
        public bool CanResolve { get; set; } = false;

        public User(string username, string password)
        {
            Username = username;
            Password = password;

            Instances.Add(Username, this);
        }
    }
}
