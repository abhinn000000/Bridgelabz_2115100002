using System;

public class StringUtils
{
    // Reverses a string
    public string Reverse(string str)
    {
        if (string.IsNullOrEmpty(str)) return str;
        char[] charArray = str.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    // Checks if a string is a palindrome
    public bool IsPalindrome(string str)
    {
        if (string.IsNullOrEmpty(str)) return false;
        string reversed = Reverse(str);
        return string.Equals(str, reversed, StringComparison.OrdinalIgnoreCase);
    }

    // Converts a string to uppercase
    public string ToUpperCase(string str)
    {
        return str?.ToUpper();
    }
}
