using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

class program7
{
    static void Main()
    {
        string filePath = "employees.csv"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            List<(string ID, string Name, string Department, decimal Salary)> employees = new List<(string, string, string, decimal)>();

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

                    if (values.Length == 4 && decimal.TryParse(values[3], NumberStyles.Number, CultureInfo.InvariantCulture, out decimal salary))
                    {
                        employees.Add((values[0], values[1], values[2], salary));
                    }
                }
            }

            var topEmployees = employees.OrderByDescending(emp => emp.Salary).Take(5);

            Console.WriteLine("Top 5 Highest-Paid Employees:");

            foreach (var emp in topEmployees)
            {
                Console.WriteLine($"ID: {emp.ID}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary:C}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
