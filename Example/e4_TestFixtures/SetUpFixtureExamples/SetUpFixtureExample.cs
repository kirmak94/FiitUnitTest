using NUnit.Framework;

namespace e2_TestFixtures.SetUpFixtureExamples;

[SetUpFixture]
public class SetUpFixtureExample
{
    [OneTimeSetUp]
    public void SetUpFixtureOneTimeSetUp()
    {
        TestContext.Out.WriteLine("FixtureOneTimeSetUp");
    }

    [OneTimeTearDown]
    public void SetUpFixtureOneTimeTearDown()
    {
        TestContext.Out.WriteLine("FixtureOneTimeTearDown");
    }
}