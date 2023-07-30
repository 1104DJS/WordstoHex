using System.Numerics;

static BigInteger perimeter(BigInteger n) {
    BigInteger num = n + 1; BigInteger sum = 0;
    BigInteger temp1 = 0, temp2 = 1;

    for (int i = 0; i <= num; i++) {
      BigInteger fibNumber = temp1;
      BigInteger temp = temp1;
          
      sum += fibNumber;
      temp1 = temp2;
      temp2 = temp + temp2;
    }

    return 4 * sum;
}

System.Console.WriteLine(perimeter(5));