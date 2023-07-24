using System;
using System.Linq;
using System.Text;

//Console.WriteLine(Decode(".... . -.--    .--- ..- -.. ."));
Console.WriteLine(Decode("- .... .   .--- --- -...   .--. --- .-. .-.. ."));
Console.WriteLine(Decode("... --- ... -.-.--   - .... .   --.- ..- .. -.-. -.-   -... .-. --- .-- -.   ..-. --- -..-   .--- ..- -- .--. ...   --- ...- . .-.   - .... .   .-.. .- --.. -.--   -.. --- --. .-.-.-   "));

static string Decode(string morseCode)
{
    string[] strList = morseCode.Split(' ');
    string finalString = "";

    for (int i = 0; i < strList.Length; i++)
    {
        if (strList[i] != string.Empty)
        {
            finalString += Get(strList[i]);
        }
        else if (i > 0 && strList[i-1] != string.Empty)
        {
            if (i > 0 && strList[i-1] != string.Empty && i != strList.Length - 1)
            {
                finalString.Append(' ');
            }

            if (i != strList.Length - 1){
                if (i == strList.Length - 2 && strList[strList.Length - 1] == string.Empty) { return finalString; }
                finalString += ' ';

            }
        }
    }

    return finalString;
}


static char Get(string input)
{
    Dictionary<char, string> morseCodeDictionary = new()
    {
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."},
        {'!', "-.-.--"},
        {'.', ".-.-.-"}
    };

    input = input.ToUpper();

    if (morseCodeDictionary.ContainsValue(input))
    {
        foreach (KeyValuePair<char, string> pair in morseCodeDictionary)
        {
            if (pair.Value == input)
            {
                return pair.Key;
            }
        }
    }

    return '\0'; // Return null character if no matching Morse code found
}

