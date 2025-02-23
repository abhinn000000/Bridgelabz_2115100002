using System;
using System.Text.RegularExpressions;

class program11{
    static void Main()
    {
        string[] cardNumbers = { "4111111111111111", "5500000000000004", "1234567812345678", "4222222222222", "5105105105105100" };

        foreach (var card in cardNumbers)
        {
            Console.WriteLine($"{card} → {(IsValidCreditCard(card) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidCreditCard(string cardNumber)
    {
        return Regex.IsMatch(cardNumber, @"^(4\d{15}|5[1-5]\d{14})$");
    }
}
