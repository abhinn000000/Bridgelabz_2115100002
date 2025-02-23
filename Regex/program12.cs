using System;
using System.Text.RegularExpressions;
using System.Linq;

class program12
{
    static void Main()
    {
        string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
        string[] languages = { "JavaScript", "Java", "Python", "Go", "C#", "C++", "Ruby", "Swift", "PHP", "Kotlin" };

        foreach (var lang in ExtractProgrammingLanguages(text, languages))
        {
            Console.WriteLine(lang);
        }
    }

    static string[] ExtractProgrammingLanguages(string text, string[] languageList)
    {
        return languageList.Where(lang => Regex.IsMatch(text, $@"\b{Regex.Escape(lang)}\b")).ToArray();
    }
}
