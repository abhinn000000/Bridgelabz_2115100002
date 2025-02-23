using System;
using System.Text.RegularExpressions;

class program3
{
    static void Main()
    {
        string[] colors = { "#FFA500", "#ff4500", "#123", "#abcdef", "#GGHHII", "123456" };

        foreach (var color in colors)
        {
            Console.WriteLine($"{color} → {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidHexColor(string color)
    {
        return Regex.IsMatch(color, @"^#([A-Fa-f0-9]{6})$");
    }
}
