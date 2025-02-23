using System;

public class DatabaseConnection
{
    public bool IsConnected { get; private set; } = false;

    public void Connect()
    {
        if (IsConnected)
            throw new InvalidOperationException("Already connected to the database.");

        IsConnected = true;
        Console.WriteLine("Database connected.");
    }

    public void Disconnect()
    {
        if (!IsConnected)
            throw new InvalidOperationException("No active connection to disconnect.");

        IsConnected = false;
        Console.WriteLine("Database disconnected.");
    }
}
