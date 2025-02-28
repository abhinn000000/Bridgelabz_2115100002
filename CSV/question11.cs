using System;
using System.IO;

class program11
{
    static void Main()
    {
        string filePath = "large_students.csv"; 
        int batchSize = 100;  
        int totalRecordsProcessed = 0;

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
                int batchCount = 0;

                while ((line = reader.ReadLine()) != null)
                {
                    if (isHeader) { isHeader = false; continue; } 

                    batchCount++;
                    totalRecordsProcessed++;

                    

                    if (batchCount == batchSize)
                    {
                        Console.WriteLine($"Processed {totalRecordsProcessed} records...");
                        batchCount = 0; 
                    }
                }
            }

            Console.WriteLine($"Total records processed: {totalRecordsProcessed}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading the file: " + ex.Message);
        }
    }
}
