using System;
using System.Collections.Generic;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
class CacheResultAttribute : Attribute { }

//implement a Cache Mechanism
class CachedOperations
{
    private static readonly Dictionary<string, object> Cache = new Dictionary<string, object>();

    [CacheResult] // Marks method for caching
    public int ExpensiveComputation(int number)
    {
        string key = $"{nameof(ExpensiveComputation)}({number})";

        if (Cache.ContainsKey(key))
        {
            Console.WriteLine($"Returning cached result for {number}");
            return (int)Cache[key];
        }

        Console.WriteLine($"Computing result for {number}");
        int result = number * number; // Simulated expensive operation
        Cache[key] = result;
        return result;
    }
}

//invoke Method and Use Cache
class program7
{
    static void Main()
    {
        CachedOperations operations = new CachedOperations();

        Console.WriteLine(operations.ExpensiveComputation(5));
        Console.WriteLine(operations.ExpensiveComputation(5)); // Should return cached result
        Console.WriteLine(operations.ExpensiveComputation(10));
        Console.WriteLine(operations.ExpensiveComputation(10)); // Should return cached result
    }
}
