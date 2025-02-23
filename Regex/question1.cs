using System;
using System.Text.RegularExpressions;

class program1
{
    static void Main()
    {
        string[] usernames = { "user_123", "123user", "us", "ValidUser_1", "toolongusername12345" };

        foreach (var username in usernames)
        {
            Console.WriteLine($"{username} → {(IsValidUsername(username) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidUsername(string username)
    {
        return Regex.IsMatch(username, @"^[A-Za-z][A-Za-z0-9_]{4,14}$");
    }
}
