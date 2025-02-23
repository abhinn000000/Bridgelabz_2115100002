using NUnit.Framework;
using System;

[TestFixture]
public class MathOperationsTests
{
    private MathOperations _mathOperations;

    [SetUp]
    public void Setup()
    {
        _mathOperations = new MathOperations();
    }

    [Test]
    public void Divide_ByZero_ThrowsArithmeticException()
    {
        Assert.Throws<ArithmeticException>(() => _mathOperations.Divide(10, 0));
    }

    [Test]
    public void Divide_ValidNumbers_ReturnsQuotient()
    {
        Assert.AreEqual(5, _mathOperations.Divide(10, 2));
    }
}
