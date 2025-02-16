using System;
using System.IO;

namespace BinaryFileReader
{
    internal class BinaryReaderClass
    {
        public void ReadBinaryFile(string filePath)
        {
            try
            {
                using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                using (StreamReader reader = new StreamReader(fs))
                {
                    int byteRead;
                    while ((byteRead = reader.Read()) != -1)
                    {
                        Console.Write((char)byteRead);
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
        //    BinaryReaderClass binaryReader = new BinaryReaderClass();

        //    Console.Write("Enter the binary file path: ");
        //    string filePath = Console.ReadLine();

        //    binaryReader.ReadBinaryFile(filePath);
        //}
    }
}
