using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.Json;
using CsvHelper;
using CsvHelper.Configuration;

class program16
{
    static void Main()
    {
        string jsonInputPath = "ipl_data.json";
        string csvInputPath = "ipl_data.csv";
        string jsonOutputPath = "ipl_data_censored.json";
        string csvOutputPath = "ipl_data_censored.csv";

        // Process JSON Data
        if (File.Exists(jsonInputPath))
        {
            string jsonData = File.ReadAllText(jsonInputPath);
            List<Match> matches = JsonSerializer.Deserialize<List<Match>>(jsonData);
            matches.ForEach(CensorMatch);
            File.WriteAllText(jsonOutputPath, JsonSerializer.Serialize(matches, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine("Censored JSON file saved: " + jsonOutputPath);
        }

        // Process CSV Data
        if (File.Exists(csvInputPath))
        {
            using var reader = new StreamReader(csvInputPath);
            using var csvReader = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            var matches = csvReader.GetRecords<Match>().ToList();

            matches.ForEach(CensorMatch);

            using var writer = new StreamWriter(csvOutputPath);
            using var csvWriter = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            csvWriter.WriteRecords(matches);
            Console.WriteLine("Censored CSV file saved: " + csvOutputPath);
        }
    }

    static void CensorMatch(Match match)
    {
        match.Team1 = CensorTeamName(match.Team1);
        match.Team2 = CensorTeamName(match.Team2);
        match.Winner = CensorTeamName(match.Winner);
        match.PlayerOfMatch = "REDACTED";

        Dictionary<string, int> censoredScore = new Dictionary<string, int>();
        foreach (var entry in match.Score)
        {
            censoredScore[CensorTeamName(entry.Key)] = entry.Value;
        }
        match.Score = censoredScore;
    }

    static string CensorTeamName(string teamName)
    {
        string[] words = teamName.Split(' ');
        if (words.Length > 1)
        {
            words[1] = "***";
        }
        return string.Join(" ", words);
    }
}

public class Match
{
    public int MatchId { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public Dictionary<string, int> Score { get; set; }
    public string Winner { get; set; }
    public string PlayerOfMatch { get; set; }
}
