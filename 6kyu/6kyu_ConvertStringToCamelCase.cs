using System.Text.RegularExpressions;

static string ToCamelCase(string str) {
        string[] words = Regex.Split(str, "[-_]");

        for (int i = 1; i < words.Length; i++)
        {
            words[i] = char.ToUpper(words[i][0]) + words[i][1..];
        }

        return string.Concat(words);
}

System.Console.WriteLine(ToCamelCase("the-stealth-warrior"));
System.Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));
System.Console.WriteLine(ToCamelCase("The_Stealth_Warrior"));