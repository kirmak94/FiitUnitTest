namespace UserCreatorTask
{
    public class User
    {
        public User(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public string Name;
        public string Email;
        public string Password;
    }
}