using NUnit.Framework;
using UserCreatorTask;
using UserCreatorTask.UserValidators;

namespace UserValidatorTests;

public class NameValidatorTests
{
    [TestCase("Ivan Ivanov")]
    public void ShouldReturnTrue_WhenEmailIsValid(string name)
    {
        var validator = new NameValidator();

        var result = validator.IsValid(name);
        
        Assert.That(result, Is.True);
    }
}