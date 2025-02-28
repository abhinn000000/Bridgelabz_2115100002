using System;
using System.IO;

class program1
{
    static void Main()
    {
        string filePath = "students.csv";

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        using (StreamReader reader = new StreamReader(filePath))
        {
            string? line;
            bool isHeader = true;

            while ((line = reader.ReadLine()) != null)
            {
                if (isHeader) //skipping the header row
                {
                    isHeader = false;
                    continue;
                }

                string[] values = line.Split(',');

                if (values.Length == 4)
                {
                    Console.WriteLine("ID: {0}, Name: {1}, Age: {2}, Marks: {3}",
                        values[0], values[1], values[2], values[3]);
                }
                else
                {
                    Console.WriteLine("Invalid record: " + line);
                }
            }
        }
    }
}
