using System;
using System.IO;

class program5
{
    static void Main()
    {
        string filePath = "employees.csv"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        Console.Write("Enter employee name to search: ");
        string searchName = Console.ReadLine()?.Trim();

        if (string.IsNullOrEmpty(searchName))
        {
            Console.WriteLine("Invalid input!");
            return;
        }

        bool found = false;

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

                    if (values.Length == 4 && values[1].Trim().Equals(searchName, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("Employee Found!");
                        Console.WriteLine("Department: " + values[2]);
                        Console.WriteLine("Salary: " + values[3]);
                        found = true;
                        break;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("Employee not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
