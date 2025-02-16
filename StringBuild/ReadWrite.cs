using System;
using System.IO;

namespace UserInputToFile
{
    internal class FileWriter
    {
        public void WriteUserInputToFile(string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.WriteLine("Enter text to write to the file (type 'exit' to stop):");

                    while (true)
                    {
                        string userInput = Console.ReadLine();
                        if (userInput.ToLower() == "exit")
                            break;

                        writer.WriteLine(userInput);
                    }
                }
                Console.WriteLine("User input has been written to the file.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while writing to the file: " + e.Message);
            }
        }
    }

    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    FileWriter fileWriter = new FileWriter();

        //    Console.Write("Enter the file path to save the input: ");
        //    string filePath = Console.ReadLine();

        //    fileWriter.WriteUserInputToFile(filePath);
        //}
    }
}
