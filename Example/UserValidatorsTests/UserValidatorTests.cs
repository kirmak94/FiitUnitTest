using NSubstitute;
using NUnit.Framework;
using UserCreatorTask;
using UserCreatorTask.UserValidators;

namespace UserValidatorTests;

public class UserValidatorTests
{
   

    [Test]
    public void UserValidator_ReturnTrue_WhenUserValid()
    {
        var nameValidator = Substitute.For<IStringValidator>();
        var passwordValidator = Substitute.For<IStringValidator>();
        var emailValidator = Substitute.For<IStringValidator>();

        nameValidator.IsValid(Arg.Any<string>()).Returns(true);
        passwordValidator.IsValid(Arg.Any<string>()).Returns(true);
        emailValidator.IsValid(Arg.Any<string>()).Returns(true);
        
        var userValidator = new UserValidator(nameValidator, passwordValidator,
            emailValidator);
        var user = new User("Ivan Ivan", "123456@Qwerty", "asdfdad@dfasdas.asd");
        var result = userValidator.Validate(user);

        Assert.That(result.isValid, Is.True);
    }

    [Test]
    public void UserValidator_ReturnFalseWithErrorMessage_WhenInvalidName()
    {
        var nameValidator = Substitute.For<IStringValidator>();
        var passwordValidator = Substitute.For<IStringValidator>();
        var emailValidator = Substitute.For<IStringValidator>();

        nameValidator.IsValid(Arg.Any<string>()).Returns(false);
        passwordValidator.IsValid(Arg.Any<string>()).Returns(true);
        emailValidator.IsValid(Arg.Any<string>()).Returns(true);
        
        var userValidator = new UserValidator(nameValidator, passwordValidator,
            emailValidator);
        var user = new User(string.Empty, string.Empty, string.Empty);
        var result = userValidator.Validate(user);

        Assert.That(result, Is.EqualTo((false, "InvalidName")));
    }


   
}