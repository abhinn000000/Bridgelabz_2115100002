using System;
using System.Reflection;
using System.Text;
using System.Collections.Generic;

//define the Custom Attribute
[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; } // Custom JSON key

    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

//apply the Attribute to a Class
class User2
{
    [JsonField("user_name")] // Maps to "user_name" in JSON
    private string Username;

    [JsonField("user_email")] // Maps to "user_email" in JSON
    private string Email;

    public User2(string username, string email)
    {
        Username = username;
        Email = email;
    }
}

//convert an Object to a JSON String Using Reflection
class JsonSerializer
{
    public static string ToJson(object obj)
    {
        Type type = obj.GetType();
        FieldInfo[] fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
        StringBuilder jsonBuilder = new StringBuilder();
        jsonBuilder.Append("{");

        List<string> jsonPairs = new List<string>();

        foreach (FieldInfo field in fields)
        {
            var attribute = field.GetCustomAttribute<JsonFieldAttribute>();
            if (attribute != null)
            {
                string key = attribute.Name;
                string value = field.GetValue(obj)?.ToString() ?? "null";
                jsonPairs.Add($"\"{key}\": \"{value}\"");
            }
        }

        jsonBuilder.Append(string.Join(", ", jsonPairs));
        jsonBuilder.Append("}");
        return jsonBuilder.ToString();
    }
}

//test JSON Serialization
class program6
{
    static void Main()
    {
        User2 user = new User2("Alice123", "alice@example.com");
        string json = JsonSerializer.ToJson(user);
        Console.WriteLine(json);
    }
}
