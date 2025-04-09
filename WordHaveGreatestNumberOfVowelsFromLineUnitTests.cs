public class VowelFinder
{
    public static string WordWithMostVowels(string line)
    {
        if (string.IsNullOrWhiteSpace(line))
            return null;

        string[] words = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string vowels = "aeiouAEIOU";

        string wordWithMostVowels = null;
        int maxVowelCount = 0;

        foreach (var word in words)
        {
            int vowelCount = word.Count(c => vowels.Contains(c));
            if (vowelCount > maxVowelCount)
            {
                maxVowelCount = vowelCount;
                wordWithMostVowels = word;
            }
        }

        return maxVowelCount > 0 ? wordWithMostVowels : null;
    }
}
