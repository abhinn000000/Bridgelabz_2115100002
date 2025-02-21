using System;
using System.IO;
class Program
{
    static void Main()
    {
        string filePath = "largefile.txt"; // Replace with your actual large file path

        try
        {
            ReadLargeFile(filePath);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
    static void ReadLargeFile(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null) // Read line by line
            {
                if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0) // Case-insensitive search
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}