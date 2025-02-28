using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using Newtonsoft.Json;

class student14
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        string jsonFile = "students.json";
        string csvFile = "students.csv";
        string outputJsonFile = "converted_students.json";

        // Convert JSON to CSV
        ConvertJsonToCsv(jsonFile, csvFile);
        Console.WriteLine($"CSV file '{csvFile}' created successfully!");

        // Convert CSV back to JSON
        ConvertCsvToJson(csvFile, outputJsonFile);
        Console.WriteLine($"JSON file '{outputJsonFile}' created successfully!");
    }

    static void ConvertJsonToCsv(string jsonFile, string csvFile)
    {
        if (!File.Exists(jsonFile))
        {
            Console.WriteLine("JSON file not found!");
            return;
        }

        string jsonData = File.ReadAllText(jsonFile);
        List<Student> students = JsonConvert.DeserializeObject<List<Student>>(jsonData) ?? new List<Student>();

        using (StreamWriter writer = new StreamWriter(csvFile))
        {
            writer.WriteLine("ID,Name,Age,Marks"); // CSV header

            foreach (var student in students)
            {
                writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Marks}");
            }
        }
    }

    static void ConvertCsvToJson(string csvFile, string outputJsonFile)
    {
        if (!File.Exists(csvFile))
        {
            Console.WriteLine("CSV file not found!");
            return;
        }

        List<Student> students = new List<Student>();

        using (StreamReader reader = new StreamReader(csvFile))
        {
            string? line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader) { isHeader = false; continue; } // Skip header row

                string[] values = line.Split(',');
                if (values.Length == 4)
                {
                    students.Add(new Student
                    {
                        ID = int.Parse(values[0]),
                        Name = values[1],
                        Age = int.Parse(values[2]),
                        Marks = int.Parse(values[3])
                    });
                }
            }
        }

        string jsonOutput = JsonConvert.SerializeObject(students, Formatting.Indented);
        File.WriteAllText(outputJsonFile, jsonOutput);
    }
}
