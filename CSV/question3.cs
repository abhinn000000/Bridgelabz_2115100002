using System;
using System.IO;

class program3
{
    static void Main()
    {
        string filePath = "employees.csv"; 

        if (!File.Exists(filePath))
        {
            Console.WriteLine("File not found!");
            return;
        }

        try
        {
            int recordCount = 0;
            using (StreamReader reader = new StreamReader(filePath))
            {
                bool isHeader = true;
                while (reader.ReadLine() != null)
                {
                    if (isHeader) 
                    {
                        isHeader = false;
                        continue;
                    }
                    recordCount++;
                }
            }

            Console.WriteLine("Total number of records (excluding header): " + recordCount);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
