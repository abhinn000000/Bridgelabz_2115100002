using System;
using System.IO;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class Program1
{
    static void Main()
    {
        using (AnonymousPipeServerStream pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (AnonymousPipeClientStream pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.ClientSafePipeHandle))
        {
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));

            writerThread.Start();
            readerThread.Start();

            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(PipeStream pipe)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipe, Encoding.UTF8, leaveOpen: true))
            {
                writer.AutoFlush = true;
                string[] messages = { "Hello", "Inter-Thread", "Communication", "Using PipeStream" };

                foreach (string message in messages)
                {
                    Console.WriteLine($"Writer: {message}");
                    writer.WriteLine(message);
                    Thread.Sleep(500); // Simulate processing delay
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Write Error: " + ex.Message);
        }
    }

    static void ReadFromPipe(PipeStream pipe)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipe, Encoding.UTF8))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Reader received: {message}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine("Read Error: " + ex.Message);
        }
    }
}