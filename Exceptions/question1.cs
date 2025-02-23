using System;
using System.IO;

class FileReader
{
    public void ReadFile(string filePath)
    {
        try
        {
            if (!File.Exists(filePath))
            {
                throw new IOException("File not found");
            }

            string content = File.ReadAllText(filePath);
            Console.WriteLine("File Contents:\n" + content);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class program1
{
    static void Main()
    {
        FileReader fileReader = new FileReader();
        fileReader.ReadFile("data.txt");
    }
}