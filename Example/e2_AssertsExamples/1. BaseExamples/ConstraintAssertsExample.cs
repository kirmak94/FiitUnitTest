using NUnit.Framework;

namespace Example._1._BaseExamples;

public partial class BaseAssertExamples
{
    //Constraint подход


    [Test]
    public void Constraint_WithAreEqualTest()
    {
        var a = 1;
        var b = 2;
        var expected = 4;

        var result = Calculator.Sum(a, b);

        Assert.That(result, Is.EqualTo(expected));
    }


    [Test]
    public void Constraint_WithIsEmpty()
    {
        var emptyList = new List<string> { };

        Assert.That(emptyList, Is.Empty);
    }

    [Test]
    public void Constraint_WithIsTrue()
    {
        var condition = 2 == 2;

        Assert.That(condition, Is.True);
    }


    [Test]
    public void Constraint_WithThrowTest()
    {
        Assert.That((TestDelegate)(() => Divide(1, 0)), Throws.TypeOf<DivideByZeroException>());
    }
}