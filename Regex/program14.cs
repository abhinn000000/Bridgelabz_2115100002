using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

class program14
{
    static void Main()
    {
        string input = "This is is a repeated repeated word test.";
        var repeatingWords = FindRepeatingWords(input);

        Console.WriteLine(string.Join(", ", repeatingWords));
    }

    static string[] FindRepeatingWords(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b(\w+)\b");
        Dictionary<string, int> wordCount = new Dictionary<string, int>();

        foreach (Match match in matches)
        {
            string word = match.Value.ToLower();
            if (wordCount.ContainsKey(word))
                wordCount[word]++;
            else
                wordCount[word] = 1;
        }

        return wordCount.Where(w => w.Value > 1).Select(w => w.Key).ToArray();
    }
}
