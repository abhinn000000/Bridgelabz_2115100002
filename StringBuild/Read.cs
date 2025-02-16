using System;
using System.IO;

namespace FileReadingExample
{
    internal class FileReader
    {
        public void ReadFile(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }
        }
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    FileReader fileReader = new FileReader();
        //    string filePath = "example.txt";  // Specify your file path here
        //    fileReader.ReadFile(filePath);
        //}
    }
}
