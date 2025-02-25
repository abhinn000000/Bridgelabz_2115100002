using System;
using System.Diagnostics;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
class LogExecutionTimeAttribute : Attribute { }

//apply the Attribute to Methods
class PerformanceTest
{
    [LogExecutionTime] // Applied to measure execution time
    public void FastMethod()
    {
        for (int i = 0; i < 1000; i++) { } // Simulated quick execution
    }

    [LogExecutionTime] // Applied to measure execution time
    public void SlowMethod()
    {
        System.Threading.Thread.Sleep(1000); // Simulated delay
    }
}

//measure and Print Execution Time Using Reflection
class program3
{
    static void Main()
    {
        PerformanceTest test = new PerformanceTest();
        Type type = typeof(PerformanceTest);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        foreach (MethodInfo method in methods)
        {
            if (method.GetCustomAttribute<LogExecutionTimeAttribute>() != null)
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(test, null);
                stopwatch.Stop();
                Console.WriteLine($"Method '{method.Name}' executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
