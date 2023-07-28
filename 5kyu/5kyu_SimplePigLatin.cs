static string PigIt(string str)
{
    string[] words = str.Split(' ');
    string final = "";

    foreach (string word in words) {
        if (char.IsLetter(word[0])) {
            string pigLatin = word[1..] + word[0] + "ay";
            final += pigLatin + " ";
        }
        else { final += word + " "; }
    }

    return final.TrimEnd();
}

System.Console.WriteLine(PigIt("Pig latin is cool !"));
