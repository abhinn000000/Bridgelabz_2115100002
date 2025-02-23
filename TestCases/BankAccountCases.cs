using NUnit.Framework;
using System;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _account;

    [SetUp]
    public void Setup()
    {
        _account = new BankAccount();
    }

    [Test]
    public void Deposit_ShouldIncreaseBalance()
    {
        _account.Deposit(100);
        Assert.AreEqual(100, _account.GetBalance());
    }

    [Test]
    public void Withdraw_ShouldDecreaseBalance()
    {
        _account.Deposit(200);
        _account.Withdraw(50);
        Assert.AreEqual(150, _account.GetBalance());
    }

    [Test]
    public void Withdraw_InsufficientFunds_ShouldThrowException()
    {
        _account.Deposit(50);
        Assert.Throws<InvalidOperationException>(() => _account.Withdraw(100));
    }

    [Test]
    public void Deposit_NegativeAmount_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _account.Deposit(-50));
    }

    [Test]
    public void Withdraw_NegativeAmount_ShouldThrowException()
    {
        Assert.Throws<ArgumentException>(() => _account.Withdraw(-20));
    }
}
