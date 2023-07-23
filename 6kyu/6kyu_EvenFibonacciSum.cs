using System;

System.Console.WriteLine(Fibonacci(0));
System.Console.WriteLine(Fibonacci(33));
System.Console.WriteLine(Fibonacci(25997544));

static long Fibonacci(int max) {
    long sum = 0; long pre = 0; long post = 1;
    while (post < max) {
        if (post % 2 == 0) {
            sum += post;
        }
        long temp = pre;
        pre = post;
        post += temp;
    }
    return sum;
}
