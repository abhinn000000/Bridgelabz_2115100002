using NUnit.Framework;
using System;

[TestFixture]
public class DatabaseConnectionTests
{
    private DatabaseConnection _dbConnection;

    [SetUp]
    public void Setup()
    {
        _dbConnection = new DatabaseConnection();
        _dbConnection.Connect();
    }

    [TearDown]
    public void Cleanup()
    {
        _dbConnection.Disconnect();
    }

    [Test]
    public void Connect_EstablishesConnection()
    {
        Assert.IsTrue(_dbConnection.IsConnected);
    }

    [Test]
    public void Disconnect_ClosesConnection()
    {
        _dbConnection.Disconnect();
        Assert.IsFalse(_dbConnection.IsConnected);
    }

    [Test]
    public void Connect_ThrowsException_IfAlreadyConnected()
    {
        Assert.Throws<InvalidOperationException>(() => _dbConnection.Connect());
    }

    [Test]
    public void Disconnect_ThrowsException_IfAlreadyDisconnected()
    {
        _dbConnection.Disconnect();
        Assert.Throws<InvalidOperationException>(() => _dbConnection.Disconnect());
    }
}
