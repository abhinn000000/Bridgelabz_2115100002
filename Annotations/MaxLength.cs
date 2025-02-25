using System;
using System.Reflection;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Value { get; } // Maximum allowed length

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

//apply the Attribute to a Class Field
class User
{
    [MaxLength(10)] // Restrict Username to max 10 characters
    private string Username;

    public User(string username)
    {
        ValidateMaxLength(this, nameof(Username), username);
        Username = username;
    }

    private void ValidateMaxLength(object obj, string fieldName, string value)
    {
        FieldInfo field = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        var attribute = (MaxLengthAttribute)field?.GetCustomAttribute(typeof(MaxLengthAttribute));

        if (attribute != null && value.Length > attribute.Value)
        {
            throw new ArgumentException($"Field '{fieldName}' exceeds max length of {attribute.Value} characters.");
        }
    }
}

//test the Validation
class Program
{
    static void Main()
    {
        try
        {
            User user1 = new User("ShortName"); // Valid
            Console.WriteLine("User created successfully.");

            User user2 = new User("VeryLongUsername"); // Exceeds limit
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
