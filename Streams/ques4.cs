using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Collections.Generic;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static string filePath = "employees.dat";

    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        try
        {
            Console.WriteLine("Enter the number of employees:");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Employee emp = new Employee();
                Console.WriteLine($"Enter details for Employee {i + 1}:");
                Console.Write("ID: ");
                emp.Id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                emp.Name = Console.ReadLine();
                Console.Write("Department: ");
                emp.Department = Console.ReadLine();
                Console.Write("Salary: ");
                emp.Salary = double.Parse(Console.ReadLine());
                employees.Add(emp);
            }

            SerializeEmployees(employees);
            Console.WriteLine("Employees saved successfully.");

            List<Employee> deserializedEmployees = DeserializeEmployees();
            Console.WriteLine("\nRetrieved Employees:");
            foreach (var emp in deserializedEmployees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }

    static void SerializeEmployees(List<Employee> employees)
    {
        using (FileStream fs = new FileStream(filePath, FileMode.Create))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs, employees);
        }
    }

    static List<Employee> DeserializeEmployees()
    {
        if (!File.Exists(filePath)) return new List<Employee>();

        using (FileStream fs = new FileStream(filePath, FileMode.Open))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (List<Employee>)formatter.Deserialize(fs);
        }
    }
}