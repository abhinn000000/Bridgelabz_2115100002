using System;
using System.IO;

class program4
{
    static void Main()
    {
        string filePath = "students.csv"; 

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

                Console.WriteLine("Students who scored more than 80 marks:");

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) 
                    {
                        isHeader = false;
                        continue;
                    }

                    string[] values = line.Split(',');

                    if (values.Length == 4 && int.TryParse(values[3], out int marks))
                    {
                        if (marks > 80)
                        {
                            Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Marks: {3}",
                                values[0], values[1], values[2], values[3]);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid record: " + line);
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
