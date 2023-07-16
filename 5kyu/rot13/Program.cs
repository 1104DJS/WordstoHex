Console.WriteLine(rot13("EBG13 rknzcyr.")); //should return "ROT13 example."
Console.WriteLine(rot13("This is my first ROT13 excercise!")); //should return "Guvf vf zl svefg EBG13 rkprepvfr!" 

// convert from char to ascii code
// add 13 to ascii code (shift) 

static string rot13(string input) {
    List<char> charList = input.ToList<char>();

    for (int i = 0; i < input.Length; i++) {
        int asciiNum = (int)charList[i];

        if (asciiNum >= 'a' && asciiNum <= 'z') {
            if (asciiNum > 'm') { asciiNum -= 13; }
            else { asciiNum += 13; }
        }
        else if (asciiNum >= 'A' && asciiNum <= 'Z') {
            if (asciiNum > 'M') { asciiNum -= 13; }
            else { asciiNum += 13; }
        }
        charList[i] = (char)asciiNum;
    }

    return string.Join("", charList);
}