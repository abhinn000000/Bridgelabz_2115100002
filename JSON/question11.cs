using System;
using System.Xml.Linq;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class program11
{
    static void Main()
    {
        string schemaJson = @"
        {
            ""type"": ""object"",
            ""properties"": {
                ""email"": { ""type"": ""string"", ""format"": ""email"" }
            },
            ""required"": [ ""email"" ]
        }";

        string jsonData = @"{ ""email"": ""user@example.com"" }";

        JSchema schema = JSchema.Parse(schemaJson);
        JObject jsonObject = JObject.Parse(jsonData);

        if (jsonObject.IsValid(schema, out var errors))
        {
            Console.WriteLine("✅ JSON is valid!");
        }
        else
        {
            Console.WriteLine("❌ JSON is invalid:");
            foreach (string error in errors)
            {
                Console.WriteLine($"- {error}");
            }
        }
    }
}
