using NUnit.Framework;

[TestFixture]
public class StringUtilsTests
{
    private StringUtils _stringUtils;

    [SetUp]
    public void Setup()
    {
        _stringUtils = new StringUtils();
    }

    [Test]
    public void Reverse_String_ReturnsReversedString()
    {
        Assert.AreEqual("olleh", _stringUtils.Reverse("hello"));
        Assert.AreEqual("racecar", _stringUtils.Reverse("racecar"));
        Assert.AreEqual("", _stringUtils.Reverse(""));
    }

    [Test]
    public void IsPalindrome_PalindromeString_ReturnsTrue()
    {
        Assert.IsTrue(_stringUtils.IsPalindrome("madam"));
        Assert.IsTrue(_stringUtils.IsPalindrome("Racecar"));
    }

    [Test]
    public void IsPalindrome_NonPalindromeString_ReturnsFalse()
    {
        Assert.IsFalse(_stringUtils.IsPalindrome("hello"));
    }

    [Test]
    public void ToUpperCase_String_ReturnsUppercaseString()
    {
        Assert.AreEqual("HELLO", _stringUtils.ToUpperCase("hello"));
        Assert.AreEqual("WORLD", _stringUtils.ToUpperCase("world"));
    }

    [Test]
    public void ToUpperCase_EmptyOrNullString_ReturnsSame()
    {
        Assert.AreEqual("", _stringUtils.ToUpperCase(""));
        Assert.IsNull(_stringUtils.ToUpperCase(null));
    }
}
