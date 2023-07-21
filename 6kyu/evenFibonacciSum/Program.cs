using System;

System.Console.WriteLine(Fibonacci(0));
System.Console.WriteLine(Fibonacci(33));
System.Console.WriteLine(Fibonacci(25997544));

static long Fibonacci(int max) {
    int sum = 0; int prev = 0; int current = 1;

    while (current <= max) {
        sum += current * (current % 2 == 0 ? 1 : 0);
        current = prev + (prev = current);
    }
    return sum;
}
