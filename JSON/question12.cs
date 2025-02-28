using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Nodes;

class Program
{
    static void Main()
    {
        string file1Path = "file1.json"; 
        string file2Path = "file2.json"; 

        JsonNode json1 = JsonNode.Parse(File.ReadAllText(file1Path));
        JsonNode json2 = JsonNode.Parse(File.ReadAllText(file2Path));

        foreach (var property in json2.AsObject())
        {
            json1[property.Key] = property.Value;
        }

        string mergedJson = json1.ToJsonString(new JsonSerializerOptions { WriteIndented = true });

        Console.WriteLine(mergedJson);

        File.WriteAllText("merged.json", mergedJson);
    }
}
