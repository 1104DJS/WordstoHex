#include <iostream>

int multiplyByEightOrNine(int number) {
    if (number % 2 == 0) { return number * 8; } 
    else { return number * 9; }
}

int main() {
    int result = multiplyByEightOrNine(4);
    std::cout << "The result is: " << result << std::endl;
    
    return 0;
}