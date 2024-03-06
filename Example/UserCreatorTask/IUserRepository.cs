namespace UserCreatorTask;

public interface IUserRepository
{
    public User GetUser(string email);
    public void SaveUserToDatabase(User user);
}