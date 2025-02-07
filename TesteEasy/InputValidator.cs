using System.Text.RegularExpressions;

namespace TesteEasy
{
    public static class InputValidator
    {
        public static bool IsValid(string word)
        {
            return !string.IsNullOrEmpty(word) &&
                   word.Length >= 1 && word.Length <= 100 &&
                   Regex.IsMatch(word, @"^[a-zA-Z]+$");
        }
    }
}