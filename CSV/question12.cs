using System;
using System.Collections.Generic;
using System.IO;

class program12
{
    static void Main()
    {
        string filePath = "students.csv"; 
        HashSet<int> seenIDs = new HashSet<int>();
        List<string> duplicateRecords = new List<string>();

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
                    if (isHeader) { isHeader = false; continue; } 

                    string[] values = line.Split(',');

                    if (values.Length > 0 && int.TryParse(values[0], out int id))
                    {
                        if (!seenIDs.Add(id)) 
                        {
                            duplicateRecords.Add(line);
                        }
                    }
                }
            }

            if (duplicateRecords.Count > 0)
            {
                Console.WriteLine("Duplicate Records Found:");
                foreach (var record in duplicateRecords)
                {
                    Console.WriteLine(record);
                }
            }
            else
            {
                Console.WriteLine("No duplicate records found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
