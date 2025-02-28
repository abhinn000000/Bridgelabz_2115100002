using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Xml;
using CsvHelper;
using Newtonsoft.Json;

class program14
{
    static void Main()
    {
        string csvFilePath = "data.csv"; 

        using (var reader = new StreamReader(csvFilePath))
        using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
        {
            var records = csv.GetRecords<dynamic>();

            string json = JsonConvert.SerializeObject(records, Formatting.Indented);

            Console.WriteLine(json);

            File.WriteAllText("data.json", json);
        }
    }
}
