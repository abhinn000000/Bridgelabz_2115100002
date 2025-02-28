using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

class program8
{
    static void Main()
    {
        string filePath = "employees.csv"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; 
        string phonePattern = @"^\d{10}$"; 

        List<string> invalidRows = new List<string>();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string? line;
                bool isHeader = true;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) 
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length < 6)
                    {
                        invalidRows.Add($"Invalid format: {line}");
                        continue;
                    }

                    string email = values[2].Trim();
                    string phone = values[3].Trim();

                    bool isEmailValid = Regex.IsMatch(email, emailPattern);
                    bool isPhoneValid = Regex.IsMatch(phone, phonePattern);

                    if (!isEmailValid || !isPhoneValid)
                    {
                        string error = $"Invalid record: {line} -> ";
                        if (!isEmailValid) error += "Invalid Email Format. ";
                        if (!isPhoneValid) error += "Invalid Phone Number. ";
                        invalidRows.Add(error);
                    }
                }
            }

            if (invalidRows.Count > 0)
            {
                Console.WriteLine("\nInvalid Records Found:");
                Console.WriteLine("----------------------");
                foreach (var row in invalidRows)
                {
                    Console.WriteLine(row);
                }
            }
            else
            {
                Console.WriteLine("All records are valid!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
