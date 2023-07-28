#include <iostream>
#include <string>
#include <vector>

using namespace std;

string PigIt(const string& str) {
    vector<string> words;
    string word;

    for (char c : str) { 
        if (c == ' ') { words.push_back(word); word = ""; } 
        else { word += c; }
    }

    words.push_back(word);
    string final = "";

    for (string word : words) {
        if (isalpha(word[0])) { string pigLatin = word.substr(1) + word[0] + "ay"; final += pigLatin + " ";} 
        else { final += word + " "; }
    }

    return final.substr(0, final.length() - 1);
}

int main() {
    cout << PigIt("Pig latin is cool !") << endl;

    return 0;
}
