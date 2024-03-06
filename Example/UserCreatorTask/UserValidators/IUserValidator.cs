namespace UserCreatorTask.UserValidators;

public interface IUserValidator
{
    public (bool isValid, string reason) Validate(User user);
}