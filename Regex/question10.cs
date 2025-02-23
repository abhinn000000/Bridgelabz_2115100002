using System;
using System.Text.RegularExpressions;

class program10
{
    static void Main()
    {
        string[] ipAddresses = { "192.168.1.1", "256.100.50.25", "10.0.0.256", "172.16.254.1", "999.999.999.999" };

        foreach (var ip in ipAddresses)
        {
            Console.WriteLine($"{ip} → {(IsValidIPv4(ip) ? "Valid" : "Invalid")}");
        }
    }

    static bool IsValidIPv4(string ip)
    {
        string pattern = @"^(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)\."
                       + @"(25[0-5]|2[0-4][0-9]|1?[0-9][0-9]?)$";

        return Regex.IsMatch(ip, pattern);
    }
}
