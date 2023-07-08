Console.WriteLine(w2x("Hello World How Are You My M"));

static string w2x(string words){
    string[] wordStrings = words.Split(' ');
    string[] _3LetterString = new string[wordStrings.Length];


    for (int i = 0; i < wordStrings.Length; i++) {
        if (wordStrings[i].Length > 3){
            _3LetterString[i] = wordStrings[i][..3];
        }
        else { _3LetterString[i] = wordStrings[i]; } }
    Array.Clear(wordStrings);

    foreach (string _3LT in _3LetterString) { Console.Write((_3LT) + " "); }

    for (int j = 0; j < _3LetterString.Length; j++) {
        char[] N1 = _3LetterString[j].ToCharArray();
        wordStrings[j] = "#";
        for (int k = 0; k < N1.Length; k++) {
            if (j != _3LetterString.Length){
                wordStrings[j] += ((byte)N1[k]).ToString("x2");
            }
        }

        if (wordStrings[j].Length == 5){ wordStrings[j] += "00";}
        else if (wordStrings[j].Length == 3) { wordStrings[j] += "0000";}
    }

    return string.Join(" ", wordStrings);
}
