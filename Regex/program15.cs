using System;
using System.Text.RegularExpressions;

class program15
{
    static void Main()
    {
        string[] ssnSamples = { "123-45-6789", "123456789", "987-65-4321", "000-12-3456", "666-45-6789" };

        foreach (var ssn in ssnSamples)
        {
            Console.WriteLine($"{ssn} → {(IsValidSSN(ssn) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidSSN(string ssn)
    {
        return Regex.IsMatch(ssn, @"^(?!000|666|9\d{2})\d{3}-(?!00)\d{2}-(?!0000)\d{4}$");
    }
}
