using System;
using System.IO;

class FileReader
{
    public void ReadFirstLine(string filePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First line of file: " + firstLine);
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading file");
        }
    }
}

class program6
{
    static void Main()
    {
        FileReader fileReader = new FileReader();
        fileReader.ReadFirstLine("info.txt");
    }
}
