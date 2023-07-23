Console.WriteLine(ExpandedForm(70304));

static string ExpandedForm(long num) {
    List<char> charList = num.ToString().ToList<char>();   
    int totalChar = num.ToString().Length;
    int charPos = 1; int charNum; int count = 0;
    int secIndex = 0;


    foreach (char s in charList) { if (s != '0') count++;}
    string[] stringArr = new string[count];

    for (int i = 0; i < totalChar; i++, charPos++) {
        charNum = totalChar - charPos;
        if (charList[i] != '0') {
            stringArr[secIndex] = charList[i].ToString();
            for (int j = 0; j < charNum; j++) { stringArr[secIndex] += "0"; }
            secIndex++;
        }
    }

    return string.Join(" + ", stringArr);
}