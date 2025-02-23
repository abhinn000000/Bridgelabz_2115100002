using System;
using System.Text.RegularExpressions;

class program2
{
    static void Main()
    {
        string[] plates = { "AB1234", "A12345", "XY5678", "abc123", "CD12", "EFG1234" };

        foreach (var plate in plates)
        {
            Console.WriteLine($"{plate} → {(IsValidLicensePlate(plate) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidLicensePlate(string plate)
    {
        return Regex.IsMatch(plate, @"^[A-Z]{2}\d{4}$");
    }
}
