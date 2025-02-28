using System;
using System.IO;
using System.Linq;
using System.Xml;
using Newtonsoft.Json;

class program15
{
    static void Main()
    {
        using (var context = new AppDbContext())
        {
            var employees = context.Employees.ToList();

            string jsonReport = JsonConvert.SerializeObject(employees, Formatting.Indented);

            Console.WriteLine(jsonReport);

            File.WriteAllText("EmployeeReport.json", jsonReport);
        }

        Console.WriteLine("JSON report generated successfully!");
    }
}
