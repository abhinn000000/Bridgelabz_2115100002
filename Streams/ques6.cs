using System;
using System.IO;
using System.Text;
class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        try
        {
            ConvertUppercaseToLowercase(inputFilePath, outputFilePath);
            Console.WriteLine("File conversion completed successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
    static void ConvertUppercaseToLowercase(string inputPath, string outputPath)
    {
        using (FileStream inputStream = new FileStream(inputPath, FileMode.Open, FileAccess.Read))
        using (BufferedStream bufferedInput = new BufferedStream(inputStream))
        using (StreamReader reader = new StreamReader(bufferedInput, Encoding.UTF8))

        using (FileStream outputStream = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedOutput = new BufferedStream(outputStream))
        using (StreamWriter writer = new StreamWriter(bufferedOutput, Encoding.UTF8))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine(line.ToLower());
            }
        }
    }
}