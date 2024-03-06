﻿using BaseExamples.TestCaseSourceAttributeExamples.RectangleCalculation;

namespace BaseExamples.TestCaseSourceAttributeExamples;

public class TestCases
{
    public static IEnumerable<object[]>  RectangleCasesMethod()
    {
        yield return new object[] { new Rectangle(0, 1, 2, 2), new Rectangle(0, 0, 1, 1), 0 };
        yield return new object[] { new Rectangle(0, 0, 1, 1), new Rectangle(2, 2, 3, 3), 0 };
        yield return new object[] { new Rectangle(0, 0, 2, 2), new Rectangle(1, 1, 3, 3), 1 };
    }
}