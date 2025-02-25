using System;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

//apply the Attribute to Methods
class ProjectModule
{
    [Todo("Implement login feature", "Alice", "HIGH")]
    public void Login() { }

    [Todo("Optimize search algorithm", "Bob")]
    public void Search() { }

    [Todo("Fix UI alignment issues", "Charlie", "LOW")]
    public void RenderUI() { }

    public void CompletedFeature() { }  // Not marked with Todo
}

//retrieve and Print All Pending Tasks Using Reflection
class program2
{
    static void Main()
    {
        Type type = typeof(ProjectModule);
        MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Instance);

        Console.WriteLine("Pending Tasks:");
        foreach (MethodInfo method in methods)
        {
            var attributes = method.GetCustomAttributes<TodoAttribute>();
            foreach (var attribute in attributes)
            {
                Console.WriteLine($"- {method.Name}: {attribute.Task} (Assigned to: {attribute.AssignedTo}, Priority: {attribute.Priority})");
            }
        }
    }
}
