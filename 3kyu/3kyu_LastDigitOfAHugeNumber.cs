using System;
using System.Numerics;

static int LastDigit(int[] array) {
    long sum = 1;
    long temp;
    Array.Reverse(array);

    if (array.Length == 0) { return (int)sum; }

    foreach (int num in array)
    {
        sum = (int)Math.Pow(num, temp);
    }
    sum %= 10;
    return (int)sum;
}

System.Console.WriteLine(LastDigit(Array.Empty<int>()));
System.Console.WriteLine(LastDigit(new int[] {0, 0}));
System.Console.WriteLine(LastDigit(new int[] {0,0,0}));
System.Console.WriteLine(LastDigit(new int[] {1,2}));
System.Console.WriteLine(LastDigit(new int[] {3,4,5}));
System.Console.WriteLine(LastDigit(new int[] {4,3,6}));
System.Console.WriteLine(LastDigit(new int[] {7,6,21}));
System.Console.WriteLine(LastDigit(new int[] {12,30,21}));
System.Console.WriteLine(LastDigit(new int[] {2,2,2,0}));
System.Console.WriteLine(LastDigit(new int[] {937640,767456,981242}));
System.Console.WriteLine(LastDigit(new int[] {123232,694022,140249}));
System.Console.WriteLine(LastDigit(new int[] {499942,898102,846073}));
