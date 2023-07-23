#include <iostream>
#include <string>

std::string bool_to_word(bool value) {
    return value ? "Yes" : "No";
}

int main() {
    bool result = false;
    std::cout << bool_to_word(result) << std::endl;
    return 0;
}
