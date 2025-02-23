using NUnit.Framework;

[TestFixture]
public class PasswordValidatorTests
{
    private PasswordValidator _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new PasswordValidator();
    }

    [Test]
    public void ValidPassword_ShouldReturnTrue()
    {
        Assert.IsTrue(_validator.IsValid("Secure123"));
    }

    [Test]
    public void ShortPassword_ShouldReturnFalse()
    {
        Assert.IsFalse(_validator.IsValid("S1abc"));
    }

    [Test]
    public void NoUppercaseLetter_ShouldReturnFalse()
    {
        Assert.IsFalse(_validator.IsValid("secure123"));
    }

    [Test]
    public void NoDigit_ShouldReturnFalse()
    {
        Assert.IsFalse(_validator.IsValid("SecurePass"));
    }

    [Test]
    public void EmptyPassword_ShouldReturnFalse()
    {
        Assert.IsFalse(_validator.IsValid(""));
    }

    [Test]
    public void NullPassword_ShouldReturnFalse()
    {
        Assert.IsFalse(_validator.IsValid(null));
    }
}
