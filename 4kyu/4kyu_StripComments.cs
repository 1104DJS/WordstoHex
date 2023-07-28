using System;

static string StripComments(string text, string[] commentSymbols)
{
    string[] lines = text.Split("\n");

    for (int i = 0; i < lines.Length; i++) {
        foreach (string symbol in commentSymbols) {
            int indexSymbol = lines[i].IndexOf(symbol);
            if (indexSymbol != -1) lines[i] = lines[i][..indexSymbol];
        }

        lines[i] = lines[i].TrimEnd();
    }

    return string.Join("\n", lines);
}

Console.WriteLine(StripComments("apples, !pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
