using FluentAssertions;
using NUnit.Framework;

namespace Example;

public class WithFluentAssertion
{
    // https://fluentassertions.com/basicassertions/
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    public static class PersonGetter
    {
        public static Person GetIvan()
        {
            return new Person { Name = "Ivan", Age = 22 };
        }
    }

    public class Tests
    {
        [Test]
        public void GetIvanTest_WithFluent()
        {
            var expected = new Person { Name = "Ivafn", Age = 23 };

            var actual = PersonGetter.GetIvan();

            actual.Should().BeEquivalentTo(expected);

        }
    }
}