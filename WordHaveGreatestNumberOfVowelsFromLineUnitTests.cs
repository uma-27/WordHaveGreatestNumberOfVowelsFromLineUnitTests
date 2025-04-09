using System;
using System.Linq;

public class VowelFinder
{
    public static string FindWordWithMostVowels(string multilineText)
    {
        if (string.IsNullOrWhiteSpace(multilineText))
        {
            return null;
        }

        string[] lines = multilineText.Split(new[] { '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
        string wordWithMostVowels = null;
        int maxVowelCount = 0;

        foreach (var line in lines)
        {
            string[] words = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            foreach (var word in words)
            {
                int vowelCount = CountVowels(word);
                if (vowelCount > maxVowelCount)
                {
                    maxVowelCount = vowelCount;
                    wordWithMostVowels = word;
                }
            }
        }

        // If no vowels are found, return null
        return maxVowelCount > 0 ? wordWithMostVowels : null;
    }

    private static int CountVowels(string word)
    {
        return word.Count(c => "aeiouAEIOU".Contains(c));
    }

    public static void Main(string[] args)
    {
        string multilineText = @"abcde abceee bcd
                                 hello world
                                 programming is fun";
        Console.WriteLine(FindWordWithMostVowels(multilineText)); // Output: "abceee"
    }
}