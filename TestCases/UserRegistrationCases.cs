using NUnit.Framework;
using System;

[TestFixture]
public class UserRegistrationTests
{
    private UserRegistration _registration;

    [SetUp]
    public void Setup()
    {
        _registration = new UserRegistration();
    }

    [Test]
    public void RegisterUser_ValidInputs_ShouldNotThrowException()
    {
        Assert.DoesNotThrow(() => _registration.RegisterUser("ValidUser", "test@example.com", "Secure123"));
    }

    [Test]
    public void RegisterUser_ShortUsername_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("usr", "test@example.com", "Secure123"));
    }

    [Test]
    public void RegisterUser_InvalidEmail_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "invalid-email", "Secure123"));
    }

    [Test]
    public void RegisterUser_ShortPassword_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "test@example.com", "Pass1"));
    }

    [Test]
    public void RegisterUser_PasswordWithoutUppercase_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "test@example.com", "password1"));
    }

    [Test]
    public void RegisterUser_PasswordWithoutDigit_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "test@example.com", "Password"));
    }

    [Test]
    public void RegisterUser_EmptyUsername_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("", "test@example.com", "Secure123"));
    }

    [Test]
    public void RegisterUser_EmptyEmail_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "", "Secure123"));
    }

    [Test]
    public void RegisterUser_EmptyPassword_ShouldThrowArgumentException()
    {
        Assert.Throws<ArgumentException>(() => _registration.RegisterUser("ValidUser", "test@example.com", ""));
    }
}
