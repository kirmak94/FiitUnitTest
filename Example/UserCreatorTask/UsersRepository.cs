namespace UserCreatorTask
{
    public class UsersRepository : IUserRepository
    {
        private static readonly List<User> _users = new List<User>();
        public User GetUser(string email) => _users.FirstOrDefault(x => x.Email == email);
        public void SaveUserToDatabase(User user) => _users.Add(user);
    }
}