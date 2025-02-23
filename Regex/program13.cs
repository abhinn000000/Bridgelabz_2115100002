using System;
using System.Text.RegularExpressions;
using System.Linq;

class program13
{
    static void Main()
    {
        string text = "The price is $45.99, and the discount is $ 10.50. Another price is 100.00 USD.";

        foreach (var value in ExtractCurrencyValues(text))
        {
            Console.WriteLine(value);
        }
    }

    static string[] ExtractCurrencyValues(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"\$\s*\d+(\.\d{2})?|\b\d+(\.\d{2})?\s*(USD|EUR|GBP)?\b");
        return matches.Cast<Match>().Select(m => m.Value.Trim()).ToArray();
    }
}
