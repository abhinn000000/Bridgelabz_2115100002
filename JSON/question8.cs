using System;
using System.IO;
using System.Text.Json;

class program8
{
    static void Main()
    {
        string filePath = "data.json"; 

        string jsonString = File.ReadAllText(filePath);

        using JsonDocument doc = JsonDocument.Parse(jsonString);
        JsonElement root = doc.RootElement;

        PrintJson(root);
    }

    static void PrintJson(JsonElement element, string indent = "")
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Object:
                foreach (var property in element.EnumerateObject())
                {
                    Console.WriteLine($"{indent}{property.Name}:");
                    PrintJson(property.Value, indent + "  ");
                }
                break;

            case JsonValueKind.Array:
                int index = 0;
                foreach (var item in element.EnumerateArray())
                {
                    Console.WriteLine($"{indent}[{index}]");
                    PrintJson(item, indent + "  ");
                    index++;
                }
                break;

            default:
                Console.WriteLine($"{indent}{element}");
                break;
        }
    }
}
