typedef unsigned long long ull;
class SumFct
{
  public:
  static ull perimeter(int n) {
    ull num = n + 1; ull sum = 0;
    ull temp1 = 0, temp2 = 1;

    for (int i = 0; i <= num; i++) {
      ull fibNumber = temp1;
      ull temp = temp1;
          
      sum += fibNumber;
      temp1 = temp2;
      temp2 = temp + temp2;
    }

    return 4 * sum;
  }
};