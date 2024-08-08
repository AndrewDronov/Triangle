using System.Collections;
using NUnit.Framework;

namespace Triangle.Tests;

public class Tests
{
    [TestCaseSource(typeof(TriangleData), nameof(TriangleData.TestCases))]
    public Type TypeTest(double a, double b, double c)
    {
        return Triangle.GetType(a, b, c);
    }
}

public class TriangleData
{
    public static IEnumerable TestCases
    {
        get
        {
            yield return new TestCaseData(9, 3d, 3d).Returns(Type.Obtuse);
            yield return new TestCaseData(2, 2, 2).Returns(Type.Acute);
            yield return new TestCaseData(4d, 3d, 5d).Returns(Type.Right);
            yield return new TestCaseData(2d, 2d, 2.82842712d).Returns(Type.Right);
            yield return new TestCaseData(2d, 2d, 2.92842712d).Returns(Type.Obtuse);
            yield return new TestCaseData(2d, 2d, 2.72842712d).Returns(Type.Acute);
        }
    }
}