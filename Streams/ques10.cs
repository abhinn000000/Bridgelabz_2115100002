using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        string filePath = "file.txt";

        try
        {
            Dictionary<string, int> wordCounts = CountWordsInFile(filePath);
            DisplayTopWords(wordCounts, 5);
        }
        catch (IOException ex)
        {
            Console.WriteLine("IOException: " + ex.Message);
        }
    }

    static Dictionary<string, int> CountWordsInFile(string filePath)
    {
        Dictionary<string, int> wordCounts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
        char[] delimiters = { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ';', ':', '(', ')', '[', ']', '{', '}', '"', '\'' };

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] words = line.ToLower()
                                     .Split(delimiters, StringSplitOptions.RemoveEmptyEntries);

                foreach (string word in words)
                {
                    if (wordCounts.ContainsKey(word))
                        wordCounts[word]++;
                    else
                        wordCounts[word] = 1;
                }
            }
        }
        return wordCounts;
    }

    static void DisplayTopWords(Dictionary<string, int> wordCounts, int topN)
    {
        var sortedWords = wordCounts.OrderByDescending(kv => kv.Value)
                                    .Take(topN);

        Console.WriteLine($"Total unique words: {wordCounts.Count}");
        Console.WriteLine($"Top {topN} most frequent words:");

        foreach (var pair in sortedWords)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }
}