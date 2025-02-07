namespace TesteEasy
{
    public class Program
    {
        public static void Main()
        {
            Solution solution = new Solution();

            TestFunction("DetectCapitalUse", solution.DetectCapitalUse, "USA");
            TestFunction("DetectCapitalUse", solution.DetectCapitalUse, "FlaG");
            TestFunction("DetectCapitalUse", solution.DetectCapitalUse, "Google");
            TestFunction("DetectCapitalUse", solution.DetectCapitalUse, "leetcode");
            TestFunction("DetectCapitalUseWithRegex", solution.DetectCapitalUseWithRegex, "USA");
            TestFunction("DetectCapitalUseWithSwitch", solution.DetectCapitalUseWithSwitch, "FlaG");
        }

        private static void TestFunction(string functionName, Func<string, bool> function, string word)
        {
            bool result = function(word);
            Console.WriteLine($"Function: {functionName}, Input: \"{word}\", Output: {result}");
        }
    }
}