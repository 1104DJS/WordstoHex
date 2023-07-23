Console.WriteLine(SpinWords("I love noodles!"));

static string SpinWords(string sentence)
{
    string[] words = sentence.Split(' '); // sentence to array of words
    string reverseWord = string.Empty; // initialisation of reverseWord 

    for (int i = 0; i < words.Length; i++)
    {
        string wordToReverse = words[i]; // sets wordToReverse to the current word in index of i
        if (words[i].Length >= 5) // if the length of the word is greater than 5
        {
            for (int j = words[i].Length - 1; j > -1; j--)
            {
                reverseWord += wordToReverse[j]; // reversed word
            }
            words[i] = reverseWord; // array i ammended with new word
            reverseWord = string.Empty; // resets reverse word 
        }
    }

    return string.Join(" ", words); // outputs array of words stung together and seperated by a space
}