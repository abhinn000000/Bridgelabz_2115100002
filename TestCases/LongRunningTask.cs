using System;
using System.Threading;

public class TaskProcessor
{
    public string LongRunningTask()
    {
        Thread.Sleep(3000); //simulating a long-running task (3 seconds)
        return "Task Completed";
    }
}
