using System;
using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        if (string.IsNullOrEmpty(password))
            return false;

        return password.Length >= 8 &&
               Regex.IsMatch(password, @"[A-Z]") && // At least one uppercase letter
               Regex.IsMatch(password, @"\d");     // At least one digit
    }
}
