using System;
using System.Text.RegularExpressions;
using System.Linq;

class program7
{
    static void Main()
    {
        string text = "Visit https://www.google.com and http://example.org for more info. Also check out https://sub.domain.net/page.";

        foreach (var link in ExtractLinks(text))
        {
            Console.WriteLine(link);
        }
    }

    static string[] ExtractLinks(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\bhttps?://[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}(/\S*)?\b");
        return matches.Cast<Match>().Select(m => m.Value).ToArray();
    }
}
