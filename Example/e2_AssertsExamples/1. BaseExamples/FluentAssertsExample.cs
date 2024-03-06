using FluentAssertions;
using NUnit.Framework;

namespace Example._1._BaseExamples;

public partial class BaseAssertExamples
{
    //Документация и примеры https://fluentassertions.com/

    [Test]
    public void FluentAreEqualTest()
    {
        var a = 1;
        var b = 2;
        var expected = 4;

        var result = Calculator.Sum(a, b);
        
       result.Should().Be(expected);
    }

    [Test]
    public void FluentIsEmptyTest()
    {
        var emptyList = new List<string> { };
        
        emptyList.Should().BeEmpty();
    }

    [Test]
    public void FluentIsTrueTest()
    {
        var condition = 2 == 2;
        
        condition.Should().BeTrue();
    }

    [Test]
    public void FluentThrowTest()
    {
        var action = () => Divide(1, 0);
        action.Should().Throw<DivideByZeroException>()
            .WithMessage("Attempted to divide by zero.");
    }

    [TestCase(1, 2, 4)]
    public void FluentWithMessageTest(int a, int b, int expected)
    {
        Calculator.Sum(a, b).Should().Be(expected, because: $"sum of {a} and {b} is {expected}");
    }
}