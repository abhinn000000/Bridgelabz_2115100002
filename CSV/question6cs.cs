using System;
using System.IO;
using System.Globalization;

class program6
{
    static void Main()
    {
        string inputFile = "employees.csv";       
        string outputFile = "updated_employees.csv"; 

        if (!File.Exists(inputFile))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            string[] lines = File.ReadAllLines(inputFile);
            string[] updatedLines = new string[lines.Length];

            updatedLines[0] = lines[0];

            for (int i = 1; i < lines.Length; i++)
            {
                string[] values = lines[i].Split(',');

                if (values.Length == 4 && values[2].Trim().Equals("IT", StringComparison.OrdinalIgnoreCase))
                {
                    if (decimal.TryParse(values[3], NumberStyles.Number, CultureInfo.InvariantCulture, out decimal salary))
                    {
                        salary *= 1.10m; 
                        values[3] = salary.ToString("F2", CultureInfo.InvariantCulture);
                    }
                }

                updatedLines[i] = string.Join(",", values);
            }

            File.WriteAllLines(outputFile, updatedLines);

            Console.WriteLine("Salaries updated successfully! Check 'updated_employees.csv'.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing the file: " + ex.Message);
        }
    }
}
