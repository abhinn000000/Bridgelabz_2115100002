using NUnit.Framework;
using System;

[TestFixture]
public class DateFormatterTests
{
    private DateFormatter _formatter;

    [SetUp]
    public void Setup()
    {
        _formatter = new DateFormatter();
    }

    [Test]
    public void FormatDate_ValidDate_ShouldReturnFormattedDate()
    {
        string result = _formatter.FormatDate("2025-02-22");
        Assert.AreEqual("22-02-2025", result);
    }

    [Test]
    public void FormatDate_AnotherValidDate_ShouldReturnFormattedDate()
    {
        string result = _formatter.FormatDate("2000-12-31");
        Assert.AreEqual("31-12-2000", result);
    }

    [Test]
    public void FormatDate_InvalidFormat_ShouldThrowFormatException()
    {
        Assert.Throws<FormatException>(() => _formatter.FormatDate("22-02-2025"));
    }

    [Test]
    public void FormatDate_EmptyString_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _formatter.FormatDate(""));
    }

    [Test]
    public void FormatDate_NullInput_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _formatter.FormatDate(null));
    }

    [Test]
    public void FormatDate_InvalidDate_ShouldThrowFormatException()
    {
        Assert.Throws<FormatException>(() => _formatter.FormatDate("2025-13-40"));
    }
}
