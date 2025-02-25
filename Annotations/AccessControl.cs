using System;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; } // Allowed role

    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

//simulate User Roles
class AppUser
{
    public string Role { get; } // Stores the user's role

    public AppUser(string role)
    {
        Role = role;
    }
}

//apply the Attribute to Methods
class SecureOperations
{
    [RoleAllowed("ADMIN")] // Only ADMIN users can access
    public void AdminTask()
    {
        Console.WriteLine("Admin task executed successfully.");
    }
}

//validate Access Before Invoking the Method
class program5
{
    static void ExecuteIfAllowed(User user, object obj, string methodName)
    {
        Type type = obj.GetType();
        MethodInfo method = type.GetMethod(methodName, BindingFlags.Public | BindingFlags.Instance);

        var attribute = method?.GetCustomAttribute<RoleAllowedAttribute>();

        if (attribute != null && attribute.Role != user.Role)
        {
            Console.WriteLine("Access Denied!");
            return;
        }

        method?.Invoke(obj, null);
    }

    static void Main()
    {
        AppUser adminUser = new AppUser("ADMIN");
        AppUser regularUser = new AppUser("USER");

        SecureOperations operations = new SecureOperations();

        Console.WriteLine("Admin trying to execute AdminTask:");
        ExecuteIfAllowed(adminUser, operations, "AdminTask");
        Console.WriteLine("Regular user trying to execute AdminTask:");
        ExecuteIfAllowed(regularUser, operations, "AdminTask");
    }
}
