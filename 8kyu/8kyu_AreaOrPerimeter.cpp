#include <iostream>

using namespace std;

int area_or_perimeter(int l, int w) {
    if (l == w) return l*w;
    else return 2*(l+w);
}

int main(){
    cout << area_or_perimeter(3, 3) << endl;
    cout << area_or_perimeter(6, 10) <<  endl;
}