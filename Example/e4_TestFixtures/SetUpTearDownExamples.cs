using NUnit.Framework;

namespace e2_TestFixtures;

public class SetUpTearDownExamples
{
    [SetUp]
    public static void DoSomethingBeforeTest()
    {
        TestContext.Out.WriteLine("something before test");
    }

    [TearDown]
    public static void DoSomethingAfterTest()
    {
        TestContext.Out.WriteLine("something after test");
    }

    #region example

    [Test]
    public void MyTest()
    {
        Assert.That(false);
    }

    [Test]
    public void MyTest2()
    {
        Assert.That(false);
    }

    #endregion
}