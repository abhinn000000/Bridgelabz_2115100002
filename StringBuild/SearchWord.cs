using System;

namespace StringBuilder
{
    internal class SearchWord
    {
        public void searchWord()
        {
            string[] arr = new string[] { "Hi im abhinn", "I like to code in C#", "I like Cricket" };
            Console.WriteLine("Enter the word to search for: ");
            string toSearch = Console.ReadLine();

            foreach (string sentence in arr)
            {
                string word = "";
                foreach (char ch in sentence + " ")  // Adding space at the end to capture the last word
                {
                    if (ch != ' ')
                    {
                        word += ch;  // Building the word character by character
                    }
                    else
                    {
                        if (word == toSearch)
                        {
                            Console.WriteLine(sentence);  // Print the entire sentence if the word matches
                            break;
                        }
                        word = "";  // Reset word for the next one
                    }
                }
            }
        }
    }

    internal class program4
    {
        //static void Main(string[] args)
        //{
        //    SearchWord searchWord = new SearchWord();
        //    searchWord.searchWord();
        //}
    }
}
