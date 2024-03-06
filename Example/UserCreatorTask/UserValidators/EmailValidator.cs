using System.Text.RegularExpressions;

namespace UserCreatorTask.UserValidators;

public class EmailValidator: IStringValidator
{
    public bool IsValid(string value)
    {
        var regex =  new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
        return regex.Match(value).Success;
    }
}