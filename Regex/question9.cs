using System;
using System.Text.RegularExpressions;

class program9
{
    static void Main()
    {
        string input = "This is a damn bad example with some stupid words.";
        string[] badWords = { "damn", "stupid" };

        string censoredText = CensorBadWords(input, badWords);
        Console.WriteLine(censoredText);
    }

    static string CensorBadWords(string text, string[] badWords)
    {
        foreach (string word in badWords)
        {
            text = Regex.Replace(text, $@"\b{word}\b", "****", RegexOptions.IgnoreCase);
        }
        return text;
    }
}
