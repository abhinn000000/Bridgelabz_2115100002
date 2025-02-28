using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

class Employee
{
    public int EmployeeID { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public string Email { get; set; }
    public decimal Salary { get; set; }
}

class program15
{
    private static readonly string encryptionKey = "MySecretKey12345"; 

    static void Main()
    {
        string csvFile = "employees_encrypted.csv";

        List<Employee> employees = new List<Employee>
        {
            new Employee { EmployeeID = 1, Name = "Alice", Department = "IT", Email = "alice@example.com", Salary = 60000 },
            new Employee { EmployeeID = 2, Name = "Bob", Department = "HR", Email = "bob@example.com", Salary = 50000 },
            new Employee { EmployeeID = 3, Name = "Charlie", Department = "Finance", Email = "charlie@example.com", Salary = 55000 },
            new Employee { EmployeeID = 4, Name = "David", Department = "IT", Email = "david@example.com", Salary = 65000 }
        };

        WriteEncryptedCsv(csvFile, employees);
        Console.WriteLine($"Encrypted CSV file '{csvFile}' created successfully!");

        ReadAndDecryptCsv(csvFile);
    }

    static void WriteEncryptedCsv(string csvFile, List<Employee> employees)
    {
        using (StreamWriter writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("EmployeeID,Name,Department,Email,Salary");

            foreach (var emp in employees)
            {
                string encryptedEmail = Encrypt(emp.Email);
                string encryptedSalary = Encrypt(emp.Salary.ToString());

                writer.WriteLine($"{emp.EmployeeID},{emp.Name},{emp.Department},{encryptedEmail},{encryptedSalary}");
            }
        }
    }

    static void ReadAndDecryptCsv(string csvFile)
    {
        if (!File.Exists(csvFile))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        using (StreamReader reader = new StreamReader(csvFile))
        {
            string? line;
            bool isHeader = true;

            Console.WriteLine("\nDecrypted Employee Records:");

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader) { isHeader = false; continue; } 

                string[] values = line.Split(',');
                if (values.Length == 5)
                {
                    int employeeId = int.Parse(values[0]);
                    string name = values[1];
                    string department = values[2];
                    string decryptedEmail = Decrypt(values[3]);
                    decimal decryptedSalary = decimal.Parse(Decrypt(values[4]));

                    Console.WriteLine($"ID: {employeeId}, Name: {name}, Dept: {department}, Email: {decryptedEmail}, Salary: {decryptedSalary}");
                }
            }
        }
    }

    static string Encrypt(string text)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
            aes.IV = new byte[16]; 

            using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(text);
                byte[] encryptedBytes = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);
                return Convert.ToBase64String(encryptedBytes);
            }
        }
    }

    static string Decrypt(string encryptedText)
    {
        using (Aes aes = Aes.Create())
        {
            aes.Key = Encoding.UTF8.GetBytes(encryptionKey);
            aes.IV = new byte[16];

            using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
            {
                byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                byte[] decryptedBytes = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);
                return Encoding.UTF8.GetString(decryptedBytes);
            }
        }
    }
}
