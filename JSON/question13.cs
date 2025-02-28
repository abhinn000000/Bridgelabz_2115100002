using System;
using System.Xml.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class program13
{
    static void Main()
    {
        string json = @"{
            ""name"": ""Alice"",
            ""age"": 30,
            ""email"": ""alice@example.com"",
            ""address"": {
                ""city"": ""New York"",
                ""zip"": ""10001""
            }
        }";

        JObject jsonObject = JObject.Parse(json);
        XDocument xmlDocument = JsonConvert.DeserializeXNode(jsonObject.ToString(), "Root");

        Console.WriteLine(xmlDocument);
    }
}
