using System;

static string sumStrings(string a, string b) {
    int maxLength = Math.Max(a.Length, b.Length); int[] result = new int[maxLength + 1];
    int remain = 0; int sum = 0;
    int numA, numB;

    for (int i = 0; i < maxLength || remain > 0; i++) {
        numA = i < a.Length ? a[a.Length - 1 - i] - '0' : 0;
        numB = i < b.Length ? b[b.Length - 1 - i] - '0' : 0;
        sum = numA + numB + remain;
        remain = sum / 10;
        sum %= 10;
        result[maxLength - i] = sum;
    }

    return string.Join("", result).TrimStart('0');
}

Console.WriteLine(sumStrings("5", "5"));