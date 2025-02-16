using System;
using System.IO;

namespace WordCountInFile
{
    internal class WordCounter
    {
        public int CountWordOccurrences(string filePath, string wordToFind)
        {
            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(new char[] { ' ', '\t', ',', '.', '!', '?', ';', ':', '-' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            if (word.Equals(wordToFind, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        }
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("The file was not found.");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred while reading the file: " + e.Message);
            }

            return count;
        }
    }

    internal class CountOccurrnce
    {
        //static void Main(string[] args)
        //{
        //    WordCounter wordCounter = new WordCounter();

        //    Console.Write("Enter the file path: ");
        //    string filePath = Console.ReadLine();

        //    Console.Write("Enter the word to find: ");
        //    string wordToFind = Console.ReadLine();

        //    int occurrences = wordCounter.CountWordOccurrences(filePath, wordToFind);

        //    Console.WriteLine($"The word '{wordToFind}' appears {occurrences} times in the file.");
        //}
    }
}
