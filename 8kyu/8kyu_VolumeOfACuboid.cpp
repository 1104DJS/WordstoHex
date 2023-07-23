#include <iostream>

double getVolumeOfCuboid(double length, double width, double height) {
  return length * width * height;
}

int main() {
    std::cout << getVolumeOfCuboid(5, 5, 5) << std::endl;
    return 0;
}