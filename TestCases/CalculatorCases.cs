using NUnit.Framework;
using System;

[TestFixture]
public class CalculatorTests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void Add_TwoNumbers_ReturnsSum()
    {
        Assert.AreEqual(10, _calculator.Add(6, 4));
    }

    [Test]
    public void Subtract_TwoNumbers_ReturnsDifference()
    {
        Assert.AreEqual(2, _calculator.Subtract(6, 4));
    }

    [Test]
    public void Multiply_TwoNumbers_ReturnsProduct()
    {
        Assert.AreEqual(24, _calculator.Multiply(6, 4));
    }

    [Test]
    public void Divide_TwoNumbers_ReturnsQuotient()
    {
        Assert.AreEqual(2, _calculator.Divide(8, 4));
    }

    [Test]
    public void Divide_ByZero_ThrowsException()
    {
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(8, 0));
    }
}
