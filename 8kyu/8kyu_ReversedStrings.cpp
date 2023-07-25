#include <iostream>
#include <string>

using namespace std;

string reverseString(string str) {
    string temp = "";
    for (int i = 0; i < str.length(); i++) {
        temp += str[str.length()- (1+i)];
    }
    return temp;
}

int main() {
    cout << reverseString("Hello") << endl;
}