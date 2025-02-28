using System;
using System.Text.Json;
using System.Text.Json.Nodes;

class program4
{
    static void Main()
    {
        string json1 = "{ \"name\": \"Alice\", \"email\": \"alice@example.com\" }";
        string json2 = "{ \"age\": 30, \"city\": \"New York\" }";

        JsonNode obj1 = JsonNode.Parse(json1);
        JsonNode obj2 = JsonNode.Parse(json2);

        foreach (var kvp in obj2.AsObject())
        {
            obj1[kvp.Key] = kvp.Value;
        }

        string mergedJson = obj1.ToJsonString(new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(mergedJson);
    }
}
