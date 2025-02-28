using System;
using System.Collections.Generic;
using System.IO;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }

    public Student(int id, string name, int age, int marks)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
    }

    public override string ToString()
    {
        return $"Student {{ ID: {ID}, Name: {Name}, Age: {Age}, Marks: {Marks} }}";
    }
}

class program9
{
    static void Main()
    {
        string filePath = "students.csv"; 
        List<Student> studentList = new List<Student>();

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

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

                    if (values.Length == 4 &&
                        int.TryParse(values[0], out int id) &&
                        int.TryParse(values[2], out int age) &&
                        int.TryParse(values[3], out int marks))
                    {
                        string name = values[1].Trim();
                        studentList.Add(new Student(id, name, age, marks));
                    }
                    else
                    {
                        Console.WriteLine("Skipping invalid record: " + line);
                    }
                }
            }

            Console.WriteLine("\nList of Students:");
            foreach (var student in studentList)
            {
                Console.WriteLine(student);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
