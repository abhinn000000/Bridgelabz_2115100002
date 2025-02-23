using System;
using System.Text.RegularExpressions;
using System.Linq;

class program5
{
    static void Main()
    {
        string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";

        foreach (var word in ExtractCapitalizedWords(text))
        {
            Console.Write(word + " ");
        }
    }

    static string[] ExtractCapitalizedWords(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\b[A-Z][a-z]*\b");
        return matches.Cast<Match>().Select(m => m.Value).ToArray();
    }
}
