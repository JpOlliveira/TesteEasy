using System.Text.RegularExpressions;

namespace TesteEasy
{
    public class Solution
    {
        public bool DetectCapitalUse(string word)
        {
            if (!InputValidator.IsValid(word)) return false;

            return ValidateAllUpperCase(word) ||
                   ValidateAllLowerCase(word) ||
                   ValidateFirstUpperCase(word);
        }

        // 1. Abordagem Tradicional
        private bool ValidateAllUpperCase(string word) => word.ToUpper() == word;
        private bool ValidateAllLowerCase(string word) => word.ToLower() == word;
        private bool ValidateFirstUpperCase(string word) => char.IsUpper(word[0]) && word.Substring(1).ToLower() == word.Substring(1);

        // 2. Abordagem com Regex
        public bool DetectCapitalUseWithRegex(string word)
        {
            if (!InputValidator.IsValid(word)) return false;
            return Regex.IsMatch(word, @"^([A-Z]+|[a-z]+|[A-Z][a-z]+)$");
        }

        // 3. Abordagem com Switch Expression
        public bool DetectCapitalUseWithSwitch(string word)
        {
            if (!InputValidator.IsValid(word)) return false;

            return word switch
            {
                _ when ValidateAllUpperCase(word) => true,
                _ when ValidateAllLowerCase(word) => true,
                _ when ValidateFirstUpperCase(word) => true,
                _ => false
            };
        }
    }
}