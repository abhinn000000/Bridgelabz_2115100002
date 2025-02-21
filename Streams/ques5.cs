using System;
using System.Collections;
using System.IO;
class Program
{
    static void Main()
    {
        string inputImagePath = "input.jpg";
        string outputImagePath = "output.jpg";

        try
        {
            byte[] imageBytes = ConvertImageToByteArray(inputImagePath);
            WriteByteArrayToImage(imageBytes, outputImagePath);
            if (VerifyFilesAreIdentical(inputImagePath, outputImagePath))
            {
                Console.WriteLine("Success: The output image is identical.");
            }
            else
            {
                Console.WriteLine("Error: The output image is different.");
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }
    static byte[] ConvertImageToByteArray(string imagePath)
    {
        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
        using (MemoryStream ms = new MemoryStream())
        {
            fs.CopyTo(ms);
            return ms.ToArray();
        }
    }
    static void WriteByteArrayToImage(byte[] imageBytes, string outputPath)
    {
        using (MemoryStream ms = new MemoryStream(imageBytes))
        using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write))
        {
            ms.CopyTo(fs);
        }
    }
    static bool VerifyFilesAreIdentical(string filePath1, string filePath2)
    {
        byte[] file1 = File.ReadAllBytes(filePath1);
        byte[] file2 = File.ReadAllBytes(filePath2);
        return StructuralComparisons.StructuralEqualityComparer.Equals(file1, file2);
    }
}