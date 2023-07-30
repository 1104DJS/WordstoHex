using System.Text.RegularExpressions;

static int LowercaseCountCheck(string s) {
    return Regex.Matches(s, "[a-z]").Count;
}

System.Console.WriteLine(LowercaseCountCheck("abc")); // 3
System.Console.WriteLine(LowercaseCountCheck("abcABC123!@€£#$%^&*()_-+=}{[]|\':;?/>.<,~")); // 3