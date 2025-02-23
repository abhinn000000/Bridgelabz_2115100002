using System;
using System.Text.RegularExpressions;

class program8
{
    static void Main()
    {
        string input = "This   is  an   example   with    multiple   spaces.";
        string result = ReplaceMultipleSpaces(input);
        Console.WriteLine(result);
    }

    static string ReplaceMultipleSpaces(string text)
    {
        return Regex.Replace(text, @"\s+", " ");
    }
}
