using NUnit.Framework;

namespace BaseExamples;

[TestFixture]
public class TestAttributeExamples
{
    // Базовый пример использования аттрибута. 
    [Test]
    public void Test1()
    {
        Assert.That(false);
    }

    // Добавление описания к тесту
    [Test() ]
    public void TestWithDescription()
    {
        Assert.That(true);
    }

    // Передача ожидаемого результата в параметрах теста
    [Test(ExpectedResult = 4)]
    public int TestWithExpectedResult()
    {
        return Calculator.Sum(3, 2);
    }
    [Test(ExpectedResult = 5)]
    public int TestWithExpectedResult2()
    {
        return Calculator.Sum(3, 2);
    }

    [Test(TestOf = typeof(Calculator))]
    public void TestWithTypeOf()
    {
        Assert.That(true);
    }

    // Может применяться к асинхронным тестовым методам
    [Test]
    public async Task AsyncTest()
    {
        Assert.That(true);
    }
    
}