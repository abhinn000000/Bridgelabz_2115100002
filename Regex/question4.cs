using System;
using System.Text.RegularExpressions;

class program4
{
    static void Main()
    {
        string text = "Contact us at support@example.com and info@company.org. You can also reach admin123@mail.net.";

        foreach (var email in ExtractEmails(text))
        {
            Console.WriteLine(email);
        }
    }

    static string[] ExtractEmails(string text)
    {
        MatchCollection matches = Regex.Matches(text, @"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}");
        string[] emails = new string[matches.Count];

        for (int i = 0; i < matches.Count; i++)
        {
            emails[i] = matches[i].Value;
        }

        return emails;
    }
}
