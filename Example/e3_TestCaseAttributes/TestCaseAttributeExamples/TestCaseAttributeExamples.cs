

using NUnit.Framework;

namespace BaseExamples.TestCaseAttributeExamples;

public class TestCaseAttributeExamples
{
    // With expected Result as parameter
    [TestCase(1, 2, 3)]
    [TestCase(1, 3, 4)]
    public void SimpleSumTest(int a, int b, int c)
    {
        Assert.That(Calculator.Sum(a, b), Is.EqualTo(c));
    }


    // With expected Result as attribute 
    [TestCase(2, 2, ExpectedResult = 4)]
    [TestCase(0, 1, ExpectedResult = 1)]
    [TestCase(1, -1, ExpectedResult = 2)]
    public int TestsWithExpectedResult(int a, int b)
    {
        return Calculator.Sum(a, b);
    }

    // With Name
    [TestCase(2, 2, 4, TestName = "PositiveWithPositive")]
    [TestCase(0, 1, 4, TestName = "PositiveWithZero")]
    [TestCase(1, -1, 0, TestName = "PositiveWithNegative")]
    public void TestsWithNames(int a, int b, int c)
    {
        Assert.That(Calculator.Sum(a, b), Is.EqualTo(c));
    }


    // With ignore 
    [TestCase(12, 3, ExpectedResult = 4, Ignore = "BadTest")]
    [TestCase(1, 1, ExpectedResult = 2)]
    public int TestsWithIgnoredCase(int a, int b)
    {
        return Calculator.Sum(a, b);
    }
}