
namespace ConsoleApp1
{
    public class StringUtility
    {
        public static string SummerizeText(string text, int maxLength = 20)
        {
            if (text.Length < maxLength)
                return text;
            var words = text.Split(' ');
            var totalCharacters = 0;

            var wordList = new List<string>();
            foreach (var word in words)
            {
                wordList.Add(word);
                totalCharacters += word.Length + 1;
                if (totalCharacters > maxLength)
                    break;
            }
            return string.Join(' ', wordList) + "...";
        }
    }
}
