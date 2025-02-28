using System;
using System.Data.SqlClient;
using System.IO;

class program13
{
    static void Main()
    {
        string connectionString = "Server=YOUR_SERVER;Database=YOUR_DATABASE;User Id=YOUR_USERNAME;Password=YOUR_PASSWORD;";
        string query = "SELECT EmployeeID, Name, Department, Salary FROM Employees";
        string outputFile = "employees.csv";

        try
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                using (StreamWriter writer = new StreamWriter(outputFile))
                {
                    writer.WriteLine("Employee ID,Name,Department,Salary");

                    while (reader.Read())
                    {
                        int employeeId = reader.GetInt32(0);
                        string name = reader.GetString(1);
                        string department = reader.GetString(2);
                        decimal salary = reader.GetDecimal(3);

                        writer.WriteLine($"{employeeId},{name},{department},{salary}");
                    }
                }
            }

            Console.WriteLine($"CSV file '{outputFile}' created successfully!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
