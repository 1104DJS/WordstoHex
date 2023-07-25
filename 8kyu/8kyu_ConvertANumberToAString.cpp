#include <iostream>
#include <string>

using namespace std;

string number_to_string(int num){
    return to_string(num);
}

int main() {
    cout << number_to_string(-100) << endl;
}