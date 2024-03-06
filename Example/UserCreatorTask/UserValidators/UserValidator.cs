namespace UserCreatorTask.UserValidators;

public class UserValidator : IUserValidator
{
    private IStringValidator _nameValidator;
    private IStringValidator _passwordValidator;
    private IStringValidator _emailValidator;

    public UserValidator(IStringValidator nameValidator, IStringValidator passwordValidator,
        IStringValidator emailValidator)
    {
        _nameValidator = nameValidator;
        _passwordValidator = passwordValidator;
        _emailValidator = emailValidator;
    }

    public (bool isValid, string reason) Validate(User user)
    {
        if (!_nameValidator.IsValid(user.Name))
        {
            return (false, "InvalidName");
        }

        if (!_passwordValidator.IsValid(user.Password))
        {
            return (false, "InvalidPassword");
        }

        if (!_emailValidator.IsValid(user.Email))
        {
            return (false, "InvalidEmail");
        }

        return (true, "");
    }
}