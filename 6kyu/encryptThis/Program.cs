using System.Text;
Console.WriteLine(EncryptThis("Hello Thomas"));
Console.WriteLine(EncryptThis(""));
Console.WriteLine(EncryptThis("A"));
Console.WriteLine(EncryptThis("Ab"));
Console.WriteLine(EncryptThis("Abc"));
Console.WriteLine(EncryptThis("A wise old owl lived in an oak"));
Console.WriteLine(EncryptThis("The less he spoke the more he heard"));

static string EncryptThis(string input) //, string input2 = "")
{
    string[] wordsArr = input.Split(' ');
    string[] strList = new string[wordsArr.Length];
    int firstLetter; string secondLetter; string lastLetter;
    string finalWord = string.Empty;

    // encrypt
    if (input != string.Empty) {
    for (int i = 0; i < wordsArr.Length; i++) {
        if (wordsArr[i].Length == 1) { strList[i] += ((int)wordsArr[i][0]).ToString(); continue; }
        else if (wordsArr[i].Length == 3) { strList[i] += ((int)wordsArr[i][0]).ToString() + wordsArr[i][2] + wordsArr[i][1];}
        firstLetter = wordsArr[i][0];
        secondLetter = wordsArr[i][^1].ToString(); // (is actually last letter)
        lastLetter = wordsArr[i][1].ToString(); // (is actually 2nd letter)
        StringBuilder encryptedWord = new();

        for (int j = 0; j < wordsArr[i].Length; j++)
        {
            if (j == 0) { encryptedWord.Append(firstLetter); }
            else if (j == 1) { encryptedWord.Append(secondLetter); }
            else if (j == wordsArr[i].Length - 1) { encryptedWord.Append(lastLetter); }
            else { encryptedWord.Append(wordsArr[i][j]); }
        }

        strList[i] = encryptedWord.ToString();
    }
    }

    return string.Join(" ", strList);
}
