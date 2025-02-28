using System;
using System.IO;

class program2
{
    static void Main()
    {
        string filePath = "employees.csv";

        string[] employees = {
            "ID,Name,Department,Salary",
            "1,John Doe,HR,50000",
            "2,Alice Smith,IT,65000",
            "3,Bob Johnson,Finance,70000",
            "4,Emily Davis,Marketing,55000",
            "5,Michael Brown,Sales,60000"
        };

        try
        {
            File.WriteAllLines(filePath, employees);
            Console.WriteLine("CSV file created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error writing to file: " + ex.Message);
        }
    }
}
