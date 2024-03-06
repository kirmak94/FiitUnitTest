using System.Text.RegularExpressions;

namespace UserCreatorTask.UserValidators;

public class PasswordValidator : IStringValidator
{
    public bool IsValid(string value)
    {
        var regex = new Regex("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$");
        return regex.Match(value).Success;
    }
}

