using System;
using System.Diagnostics;
using System.IO;
class BufferedFileCopy
{
    static void Main()
    {
        string sourceFile = "largefile.bin";
        string destinationFileBuffered = "destination_buffered.bin";
        string destinationFileUnbuffered = "destination_unbuffered.bin";
        int bufferSize = 4096; // 4 KB

        try
        {
            if (!File.Exists(sourceFile))
            {
                Console.WriteLine("Error: Source file does not exist.");
                return;
            }

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFileBuffered, FileMode.Create, FileAccess.Write))
            using (BufferedStream bufferedRead = new BufferedStream(fsRead, bufferSize))
            using (BufferedStream bufferedWrite = new BufferedStream(fsWrite, bufferSize))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = bufferedRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bufferedWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Buffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");
            stopwatch.Restart();
            using (FileStream fsRead = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
            using (FileStream fsWrite = new FileStream(destinationFileUnbuffered, FileMode.Create, FileAccess.Write))
            {
                byte[] buffer = new byte[bufferSize];
                int bytesRead;
                while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    fsWrite.Write(buffer, 0, bytesRead);
                }
            }
            stopwatch.Stop();
            Console.WriteLine($"Unbuffered Copy Time: {stopwatch.ElapsedMilliseconds} ms");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Exception: " + ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}