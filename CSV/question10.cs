using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Student1
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
    public string Grade { get; set; }

    public Student1(int id, string name, int age, int marks, string grade)
    {
        ID = id;
        Name = name;
        Age = age;
        Marks = marks;
        Grade = grade;
    }

    public override string ToString()
    {
        return $"{ID},{Name},{Age},{Marks},{Grade}";
    }
}

class program10
{
    static void Main()
    {
        string file1 = "students1.csv";
        string file2 = "students2.csv";
        string outputFile = "merged_students.csv";

        if (!File.Exists(file1) || !File.Exists(file2))
        {
            Console.WriteLine("One or both files not found!");
            return;
        }

        try
        {
            Dictionary<int, (string Name, int Age)> studentInfo = new Dictionary<int, (string, int)>();
            using (StreamReader reader = new StreamReader(file1))
            {
                string? line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) { isHeader = false; continue; } 

                    string[] values = line.Split(',');
                    if (values.Length == 3 && int.TryParse(values[0], out int id) && int.TryParse(values[2], out int age))
                    {
                        studentInfo[id] = (values[1].Trim(), age);
                    }
                }
            }

            List<Student1> mergedStudents = new List<Student1>();
            using (StreamReader reader = new StreamReader(file2))
            {
                string? line;
                bool isHeader = true;
                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) { isHeader = false; continue; } 

                    string[] values = line.Split(',');
                    if (values.Length == 3 && int.TryParse(values[0], out int id) && int.TryParse(values[1], out int marks))
                    {
                        string grade = values[2].Trim();
                        if (studentInfo.ContainsKey(id))
                        {
                            var (name, age) = studentInfo[id];
                            mergedStudents.Add(new Student1(id, name, age, marks, grade));
                        }
                    }
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");
                foreach (var student in mergedStudents)
                {
                    writer.WriteLine(student);
                }
            }

            Console.WriteLine("Merged file created successfully: " + outputFile);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error processing files: " + ex.Message);
        }
    }
}
