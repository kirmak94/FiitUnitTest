using NUnit.Framework;

namespace Example._1._BaseExamples;

public partial class BaseAssertExamples
{
    //Классический подход Nunit
    [Test]
    public void Classic_WithAreEqualTest()
    {
        var a = 1;
        var b = 2;
        var expected = 4;
        Assert.AreEqual(Calculator.Sum(a, b), expected);
    }

    [Test]
    public void Classic_WithIsEmptyTest()
    {
        var emptyList = new List<string> { };
        Assert.IsEmpty(emptyList);
    }

    [Test]
    public void Classic_WithIsTrueTest()
    {
        var condition = 2 == 2;
        Assert.IsTrue(condition);
    }

    [Test]
    public void Classic_WithThrowTest()
    {
        Assert.Throws<DivideByZeroException>(() => Divide(1, 0));
    }

    [Test]
    public void Classic_WithCustomMessageTest()
    {
        var a = 1;
        var b = 2;
        int expected = 4;
        
        var result = Calculator.Sum(a, b);
        
        Assert.AreEqual(result, expected, message: $"Ожидали, что сумма {a} и {b} будет равна {expected}," +
                                                   $" но получили {result}");
    }

    private int Divide(int a, int b) => a / b;
}

public class Calculator
{
    public static int Sum(int a, int b) => a + b;
}