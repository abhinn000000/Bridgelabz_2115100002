using System;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
class ImportantMethodAttribute : Attribute
{
    public string Level { get; }

    public ImportantMethodAttribute(string level = "HIGH")
    {
        Level = level;
    }
}

//applying Attribute to Methods
class Operations
{
    [ImportantMethod]
    public void CriticalOperation()
    {
        Console.WriteLine("Executing CriticalOperation...");
    }

    [ImportantMethod("MEDIUM")]
    public void RegularOperation()
    {
        Console.WriteLine("Executing RegularOperation...");
    }

    public void NonImportantMethod()
    {
        Console.WriteLine("This method is not marked as important.");
    }
}

//retrieving and printing Annotated Methods
class program1
{
    static void Main()
    {
        Type type = typeof(Operations);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        Console.WriteLine("Important Methods:");
        foreach (MethodInfo method in methods)
        {
            var attribute = (ImportantMethodAttribute)method.GetCustomAttribute(typeof(ImportantMethodAttribute));
            if (attribute != null)
            {
                Console.WriteLine($"- {method.Name} (Level: {attribute.Level})");
            }
        }
    }
}
