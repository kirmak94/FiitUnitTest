namespace e1_TestExample;

public static class CalculatorTests
{
    public static void CalculatorSumTest(int a, int b, int expected)
    {
        var actual = Calculator.Sum(a, b);

        if (actual != expected)
            throw new TestFailedException();
    }

    public class TestFailedException : Exception
    {
        public TestFailedException()
        {
        }
    }
}