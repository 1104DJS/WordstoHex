// Kata.EncryptThis("Hello") == "72olle"
// Kata.EncryptThis("good") == "103doo"
// Kata.EncryptThis("hello world") == "104olle 119drlo"

Console.WriteLine(EncryptThis("Hello"));
Console.WriteLine(EncryptThis("hello world"));
Console.WriteLine(EncryptThis("good"));


static string EncryptThis(string input){
    string[] wordsArr = input.Split(' ');
    string[] strList = new string[input.Length];

    // encrypt
    for (int i = 0; i < wordsArr.Length; i++){
        int firstLetter = wordsArr[i][0];
        string secondLetter = wordsArr[i][^1].ToString();
        string LastLetter = wordsArr[i][1].ToString();

        for (int j = 0; j < wordsArr[i].Length; j++){
            if (j == 0){
                strList[i] += firstLetter;
            }
            else if (j == 1){
                strList[i] += secondLetter;
            }
            else if (j == wordsArr[i].Length - 1){
                strList[i] += LastLetter;
            }
            else { strList[i] += wordsArr[i][j]; }
        }
    }

    return string.Join(" ", strList);
}

