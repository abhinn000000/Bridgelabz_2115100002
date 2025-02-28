using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class program5
{
    static void Main()
    {
        string schemaJson = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""name"": { ""type"": ""string"" },
                ""email"": { ""type"": ""string"", ""format"": ""email"" },
                ""age"": { ""type"": ""integer"", ""minimum"": 18 }
            },
            ""required"": [ ""name"", ""email"" ]
        }";

        string jsonData = @"{ ""name"": ""Alice"", ""email"": ""alice@example.com"", ""age"": 25 }";

        JSchema schema = JSchema.Parse(schemaJson);

        JObject jsonObject = JObject.Parse(jsonData);

        if (jsonObject.IsValid(schema, out IList<string> validationErrors))
        {
            Console.WriteLine("JSON is valid!");
        }
        else
        {
            Console.WriteLine("JSON is invalid:");
            foreach (string error in validationErrors)
            {
                Console.WriteLine($"- {error}");
            }
        }
    }
}
